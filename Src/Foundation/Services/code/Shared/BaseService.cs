using M1CP.Foundation.ServiceContracts.ServiceContracts.BaseService;
using System;
using System.Security.Cryptography.X509Certificates;
using M1CP.Foundation.Services.Helper;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.IO;
using System.Threading;
using M1CP.Foundation.Services.Constants;
using System.Xml;
using Sitecore.Data.Items;
using Newtonsoft.Json;
using Sitecore.Configuration;
using M1CP.Foundation.DependencyInjection;
using M1CP.Foundation.ServiceContracts.ServiceModel;
using M1CP.Foundation.ServiceContracts.ServiceModel.Enum;

namespace M1CP.Foundation.Services.Shared
{
    [Service(typeof(IBaseService))]
    public class BaseService : IBaseService
    {     
        public string GetData(ServiceRequest serverRequest, ServiceRequest secondaryServerRequest)
        {
            string response = string.Empty;
            int retryAttemptCount = 0;
            int maxAttemptCount = !string.IsNullOrWhiteSpace(ServiceHelper.GetServiceSettingValueByField(ServiceConstants.ServiceRetryAttemptsFieldName)) ? Convert.ToInt32(ServiceHelper.GetServiceSettingValueByField(ServiceConstants.ServiceRetryAttemptsFieldName)) : 0;
            int ServiceRetryIntervalInSec = !string.IsNullOrWhiteSpace(ServiceHelper.GetServiceSettingValueByField(ServiceConstants.ServiceRetryIntervalFieldName)) ? Convert.ToInt32(ServiceHelper.GetServiceSettingValueByField(ServiceConstants.ServiceRetryIntervalFieldName)) : 0;
            int errorCode = 0;

            // Restrict number of service calls if service calls exceeds the limit.
            if (ServiceHelper.CheckServiceCallLimit())
            {
                // Get certificate from root.
                X509Certificate2Collection certificates = new X509Certificate2Collection();
                if (serverRequest.ServerAuthRequired)
                {
                    certificates = ServiceHelper.GetCertificates();
                }

                // Do-While for service retry.
                do
                {
                    Stopwatch watch = new Stopwatch();
                    watch.Start();
                    try
                    {
                        // Increase application variable count during calling M1 service.
                        if (CacheHelper.Exists(ServiceConstants.ServiceCallCountKey))
                            CacheHelper.Set<int>(ServiceConstants.ServiceCallCountKey, CacheHelper.Get<int>(ServiceConstants.ServiceCallCountKey) + 1);
                        else
                            CacheHelper.Set<int>(ServiceConstants.ServiceCallCountKey, 1); // If key is not in Redis, then it meaning this is the 1st call.

                        HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(serverRequest.ServiceUrl);

                        httpWebRequest.Method = serverRequest.ServiceMethodType.ToString();

                        if (serverRequest.ServiceRequestType == RequestType.SOAP && !string.IsNullOrWhiteSpace(serverRequest.SOAPAction))
                            httpWebRequest.Headers.Add(ServiceConstants.SOAPActionKey, ServiceConstants.SOAPActionUrl + serverRequest.SOAPAction);

                        if (serverRequest.ServiceContentType == ContentType.JSON)
                            httpWebRequest.ContentType = ServiceConstants.JsonContentType + ServiceConstants.Utf8Charset;
                        else if (serverRequest.ServiceContentType == ContentType.XML)
                            httpWebRequest.ContentType = ServiceConstants.XmlContentType + ServiceConstants.Utf8Charset;

                        if (certificates != null && certificates.Count > 0)
                        {
                            // Add AuthTicket to request header.
                            httpWebRequest.Headers.Add(ServiceConstants.AuthTicket, GetAuthTicket());

                            ServicePointManager.CheckCertificateRevocationList = false;
                            ServicePointManager.ServerCertificateValidationCallback = (a, b, c, d) => true;
                            ServicePointManager.Expect100Continue = true;
                            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                            httpWebRequest.ClientCertificates = certificates;
                        }

                        if (!string.IsNullOrWhiteSpace(serverRequest.RequestData))
                        {
                            byte[] byteData = Encoding.UTF8.GetBytes(serverRequest.RequestData);
                            httpWebRequest.ContentLength = byteData.Length;

                            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                            {
                                streamWriter.Write(serverRequest.RequestData);
                                //streamWriter.Flush();
                            }
                        }

                        HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            response = streamReader.ReadToEnd();
                            // Log.Info("Service call succeeded for: " + serverRequest.ServiceUrl);
                        }
                    }
                    catch (Exception ex)
                    {
                        //Log.Error("Service call failed for: " + serverRequest.ServiceUrl + ". Error" + ex.Message, ex);
                        break;
                    }
                    finally
                    {
                        watch.Stop();
                        //PerformanceLog.Info("For service " + serverRequest.ServiceUrl + ", response time (in sec): " + watch.Elapsed.TotalSeconds);

                        // Decrease application variable count if response is recieved from M1 service.
                        if (CacheHelper.Exists(ServiceConstants.ServiceCallCountKey))
                            CacheHelper.Set<int>(ServiceConstants.ServiceCallCountKey, CacheHelper.Get<int>(ServiceConstants.ServiceCallCountKey) - 1);
                    }

                    // Get Error code from response.
                    if (!string.IsNullOrWhiteSpace(response))
                    {
                        if (response.ToLower().Contains("errorcode"))
                            errorCode = System.Convert.ToInt32(JsonConvert.DeserializeObject<ServiceResponseErrorInfo>(response).ErrorCode.Trim());
                        else if (response.ToLower().Contains("status") && JsonConvert.DeserializeObject<ServiceResponseMessageInfo>(response).Status.ToLower().Trim() == ErrorType.E_FAILED.ToString().ToLower())
                            errorCode = 403;
                    }

                    retryAttemptCount++;

                    // If error code is zero & response is not empty return result.
                    if (!string.IsNullOrWhiteSpace(response) && errorCode == 0)
                        break;

                    // Wait for next retry.
                    Thread.Sleep(ServiceRetryIntervalInSec * 1000);

                } while (retryAttemptCount < maxAttemptCount && (string.IsNullOrWhiteSpace(response) || errorCode != 0));

                // Call for secondary service request if not no response from primary service.
                if (secondaryServerRequest != null && (string.IsNullOrWhiteSpace(response) || errorCode != 0))
                {
                    response = GetData(secondaryServerRequest, null); // TODO: Rename to Read only service request.

                    if (!string.IsNullOrWhiteSpace(response) && System.Convert.ToInt32(JsonConvert.DeserializeObject<ServiceResponseErrorInfo>(response).ErrorCode.Trim()) == 0)
                    {
                        //Log.Info("Service call succeeded for secondary service: " + serverRequest.ServiceUrl);
                    }

                }
            }
            else
            {
                // if number service calls exceeded, send forbidden error code in response.
                ServiceResponseProperties errorObj = new ServiceResponseProperties();
                errorObj.ErrorCode = "403"; // TODO: Code need to come from Config/Constants.
                errorObj.ErrorMessage = "Application service calls exceeded, please try after sometime."; // TODO: Message need to come from Sitecore.
                response = JsonConvert.SerializeObject(errorObj);
            }
            return response;
        }

        /// <summary>
        /// Get AuhtTicket from cache or M1 Service.
        /// </summary>
        /// <returns>AuhtTicket</returns>
        public string GetAuthTicket()
        {
            try
            {
                string authTicket = CacheHelper.GetOrSetInCache<string>(ServiceConstants.AuthTicket, () => GetAuthenticationTicket());
                return authTicket;
            }
            catch (Exception ex)
            {
                //Log.Error("Error in getting authentication ticket from cache  - " + ex.Message, ex);
                return string.Empty;
            }
        }

        /// <summary>
        /// Get AuhtTicket from M1 Service.
        /// </summary>
        /// <returns>AuhtTicket</returns>
        public string GetAuthenticationTicket()
        {
            string response = string.Empty;
            try
            {
                string serviceUrl = Settings.GetSetting(ServiceConstants.SoapServiceBaseUrl) + CommonText.GetGenericConstant(ServiceConstants.SingleSignOnServiceURL);
                string requestData = string.Format(ServiceConstants.AuthTicketServiceXML, ServiceHelper.GetEncryptedSettings(ServiceConstants.ServiceUserName), ServiceHelper.GetEncryptedSettings(ServiceConstants.ServicePassWord), ServiceHelper.GetEncryptedSettings(ServiceConstants.ServiceApplicationType));

                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(serviceUrl);
                httpWebRequest.Method = MethodType.POST.ToString();
                httpWebRequest.ContentType = ServiceConstants.XmlContentType + ServiceConstants.Utf8Charset;

                byte[] byteData = Encoding.UTF8.GetBytes(requestData);
                httpWebRequest.ContentLength = byteData.Length;

                Item certificateSetting = SitecoreHelper.GetSitecoreItemById(CommonText.GetItemGuidConstant(ServiceConstants.AuthTicketCertificateItemGuid));

                if (certificateSetting != null && certificateSetting.Versions.Count > 0 &&
                    certificateSetting.Fields["CertificateName"] != null && !string.IsNullOrWhiteSpace(certificateSetting.Fields["CertificateName"].Value))
                {
                    X509Certificate2 cert = ServiceHelper.GetCertificateFromLocalStore(certificateSetting.Fields["CertificateName"].Value.Trim());

                    if (cert != null)
                    {
                        X509Certificate2Collection certificates = new X509Certificate2Collection();
                        certificates.Add(cert);
                        ServicePointManager.CheckCertificateRevocationList = false;
                        ServicePointManager.ServerCertificateValidationCallback = (a, b, c, d) => true;
                        ServicePointManager.Expect100Continue = true;
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                        httpWebRequest.ClientCertificates = certificates;
                    }
                }
                else
                {
                    //Log.Info("Auth Ticket Service Certificate Details Missing.");
                }

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(requestData);
                    streamWriter.Flush();
                }

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    string xmlResponse = streamReader.ReadToEnd();

                    if (!string.IsNullOrWhiteSpace(xmlResponse))
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.LoadXml(xmlResponse);

                        if (xmlDoc.HasChildNodes)
                            response = ServiceHelper.GetAuthNodeFromResponse(xmlDoc.ChildNodes);
                    }
                }

            }
            catch (Exception ex)
            {
                //Log.Error("Error in getting Authentication Ticket For Client  - " + ex.Message, ex);
            }

            return response;
        }
    }
}