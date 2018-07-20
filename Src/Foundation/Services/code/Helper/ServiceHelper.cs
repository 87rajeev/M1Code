using System;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using M1CP.Foundation.Services.Constants;
using Sitecore.Data.Items;

namespace M1CP.Foundation.Services.Helper
{
    public static class ServiceHelper
    {
       

        /// <summary>
        /// Get Certificates.
        /// </summary>
        /// <returns>Certificate Collection</returns>
        public static X509Certificate2Collection GetCertificates()
        {
            X509Certificate2Collection certificates = new X509Certificate2Collection();
            Item certificateSetting = SitecoreHelper.GetSitecoreItemById(CommonText.GetItemGuidConstant(ServiceConstants.M1DataServicesCertificateItemGuid));

            if (certificateSetting != null && certificateSetting.Versions.Count > 0 &&
                certificateSetting.Fields["CertificateName"] != null && !string.IsNullOrWhiteSpace(certificateSetting.Fields["CertificateName"].Value))
            {
                X509Certificate2 cert = GetCertificateFromLocalStore(certificateSetting.Fields["CertificateName"].Value.Trim());
                if (cert != null)
                    certificates.Add(cert);
            }
            else
            {
                // Log.Info("M1 Data Services Certificate Details Missing.");
            }
            return certificates;
        }



        /// <summary>
        /// Check serive call limit.
        /// </summary>
        /// <returns>True/False</returns>
        public static bool CheckServiceCallLimit()
        {
            // Get ServiceCallCount from Redis.
            int ServiceCallCount = CacheHelper.Exists(ServiceConstants.ServiceCallCountKey) ? ServiceCallCount = CacheHelper.Get<int>(ServiceConstants.ServiceCallCountKey) : 0;

            // Get number of service calls to be limited from sitecore.
            int RestrictServiceCallsTo = !string.IsNullOrWhiteSpace(GetServiceSettingValueByField(ServiceConstants.RestrictServiceCallsTo)) ? Convert.ToInt32(GetServiceSettingValueByField(ServiceConstants.RestrictServiceCallsTo)) : 0;

            return ServiceCallCount <= RestrictServiceCallsTo;
        }


        /// <summary>
        /// Get Encrypted value based on key from Config.
        /// </summary>
        /// <param name="settingKey"></param>
        /// <returns>Encrypted value</returns>
        public static string GetEncryptedSettings(string settingKey)
        {
            try
            {
                Configuration configuration = null;
                if (System.Web.HttpContext.Current != null)
                    configuration = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~");
                else
                    configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                if (configuration != null)
                {
                    ConfigurationSection section = configuration.GetSection(ServiceConstants.ConfigSectionToEncrpt);

                    if (section != null)
                    {
                        XmlDocument xDoc = new XmlDocument();
                        xDoc.LoadXml(section.SectionInformation.GetRawXml());

                        if (xDoc != null && xDoc.HasChildNodes)
                        {
                            XmlNode xList = xDoc.ChildNodes[0];
                            if (xList != null && xList.HasChildNodes)
                            {
                                var xmlElements = xList.ChildNodes.OfType<XmlElement>().Where(x => x.Attributes["name"].Value.ToLower() == settingKey.ToLower());
                                if (xmlElements != null && xmlElements.Any())
                                    return xmlElements.FirstOrDefault().SelectSingleNode("value").InnerText;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log.Error("Error in GetEncryptedSettings() - " + ex.Message, ex);
            }
            return string.Empty;
        }

        /// <summary>
        /// Get Service settings value from Sitecore.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <returns>string</returns>
        public static string GetServiceSettingValueByField(string fieldName)
        {
            Item ServiceSetting = SitecoreHelper.GetSitecoreItemById(CommonText.GetItemGuidConstant(ServiceConstants.ServiceSettingsForRetryItemGuid));

            if (ServiceSetting != null && ServiceSetting.Versions.Count > 0)
            {
                if (ServiceSetting.Fields[fieldName] != null && !string.IsNullOrWhiteSpace(ServiceSetting.Fields[fieldName].Value))
                    return ServiceSetting.Fields[fieldName].Value;
            }
            return string.Empty;
        }

        /// <summary>
        /// Get Certificate From LocalStore.
        /// </summary>
        /// <param name="certificateName"></param>
        /// <returns>Certificate</returns>
        public static X509Certificate2 GetCertificateFromLocalStore(string certificateName)
        {
            X509Certificate2 certificate = null;
            try
            {
                X509Store store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
                store.Open(OpenFlags.ReadOnly);

                if (store.Certificates.Count > 0)
                    certificate = store.Certificates.OfType<X509Certificate2>().FirstOrDef‌​ault(cert => cert.FriendlyName.Equals(certificateName));

                if (certificate == null)
                    certificate = store.Certificates.OfType<X509Certificate2>().FirstOrDef‌​ault(cert => cert.Subject.Contains("CN=" + certificateName));

                store.Close();
            }
            catch (Exception ex)
            {
                //Log.Error("Error in getting certificate from store - " + ex.Message, ex);
            }

            return certificate;
        }

        /// <summary>
        /// Parse AuhtTicket from service response.
        /// </summary>
        /// <param name="xmlNodes"></param>
        /// <returns>AuthTicket</returns>
        public static string GetAuthNodeFromResponse(XmlNodeList xmlNodes)
        {
            string authTicket = string.Empty;

            foreach (XmlNode resultNode in xmlNodes)
            {
                if (resultNode.Name.ToLower().Trim() == ServiceConstants.AuthTicket.ToLower())
                {
                    authTicket = resultNode.InnerText;
                    break;
                }
                else if (resultNode.HasChildNodes)
                {
                    authTicket = GetAuthNodeFromResponse(resultNode.ChildNodes);

                    if (!string.IsNullOrWhiteSpace(authTicket))
                        break;
                }
            }

            return authTicket;
        }
    }
}