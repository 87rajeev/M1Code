using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Services.Constants
{
    public class ServiceConstants
    {
        /// <summary>
        /// ConfigNodeAttributeKey
        /// </summary>
        static public readonly string ConfigNodeAttributeKey = "Key";

        /// <summary>
        /// ConfigNodeAttributeValue
        /// </summary>
        static public readonly string ConfigNodeAttributeValue = "Value";

        /// <summary>
        /// GenericConstantConfigNodePath
        /// </summary>
        static public readonly string GenericConstantConfigNodePath = "GenericConstants/Constant";

        /// <summary>
        /// TemplatePathConfigNodePath
        /// </summary>
        static public readonly string ItemPathConfigNodePath = "ItemPaths/Item";

        /// <summary>
        /// TemplateGuidConfigNodePath
        /// </summary>
        static public readonly string ItemGuidConfigNodePath = "ItemGuid/Item";

        static public readonly string ConfigSectionToEncrpt = "M1SSPServiceSettings/M1SSP.Properties.Settings";

        static public readonly string DictionaryDomain = "DictionaryDomain";

        static public readonly string SearchIndex = "SearchIndex";

        static public readonly string SiteName = "M1SSP";

        static public readonly string HostName = "HostName";

        static public readonly string NotFoundItemPropertyKey = "notFoundItem";

        static public readonly string RestrictServiceCallsTo = "RestrictServiceCallsTo";

        static public readonly string ServiceCallCountKey = "ServiceCallCount";

        static public readonly string ServiceRetryAttemptsFieldName = "ServiceRetryAttempts";

        static public readonly string ServiceRetryIntervalFieldName = "ServiceRetryInterval";

        static public readonly string ServiceSettingsForRetryItemGuid = "ServiceSettingsForRetryItemGuid";

        static public readonly string ExcludeText = "ExcludeText";

        static public readonly string AOText = "AO";

        static public readonly string CORIText = "CORI";

        static public readonly string ExM1Text = "Ex M1";

        static public readonly string AccessModule = "AccessModule";

        static public readonly string KeyGeneratorString = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

        #region Basic Service related constant

        static public readonly string AuthTicket = "AuthTicket";

        static public readonly string JsonContentType = "application/json;";

        static public readonly string XmlContentType = "text/xml;";

        static public readonly string XmlDocHeader = @"<?xml version=""1.0"" encoding=""utf-8""?>";

        static public readonly string Utf8Charset = "charset=\"utf-8\"";

        static public readonly string SOAPActionKey = "SOAPAction";

        static public readonly string SOAPActionUrl = "http://www.m1.com.sg/";

        static public readonly string RestServiceBaseUrl = "RestServiceBaseUrl";

        static public readonly string ReadOnlyRestServiceBaseUrl = "ReadOnlyRestServiceBaseUrl";

        static public readonly string MCSRestServiceBaseUrl = "MCSRestServiceBaseUrl";

        static public readonly string RestCDMServiceBaseUrl = "RestCDMServiceBaseUrl";

        static public readonly string SoapServiceBaseUrl = "SoapServiceBaseUrl";

        static public readonly string SoapBaseUrl = "SoapBaseUrl";

        static public readonly string ServiceUserName = "ServiceUserName";

        static public readonly string ServicePassWord = "ServicePassWord";

        static public readonly string ServiceApplicationType = "ServiceApplicationType";

        static public readonly string SingleSignOnServiceURL = "SingleSignOnServiceURL";

        static public readonly string MemoryCacheExpiryInHours = "MemoryCacheExpiryInHours";

        static public readonly string Username = "username";

        static public readonly string Password = "password";

        static public readonly string AccountType = "accountType";

        static public readonly string M1DataServicesCertificateItemGuid = "M1DataServicesCertificateItemGuid";

        static public readonly string LogoutUrl = "LogoutUrl";

        #endregion



        static public readonly string AuthTicketCertificateItemGuid = "AuthTicketCertificateItemGuid";

        static public readonly string AuthTicketServiceXML = @"<?xml version=""1.0"" encoding=""utf-8""?><soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/""><soap:Body><GetAuthenticationTicketForClients xmlns=""http://m1.com.sg/SingleSignOn/""><username>{0}</username><password>{1}</password><accountType>{2}</accountType></GetAuthenticationTicketForClients></soap:Body></soap:Envelope>";

        static public readonly string TestXMl = @"<?xml version=""1.0"" encoding=""utf-8""?><soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/""><soap:Header><AuthenticationSoapHeader xmlns=""http://www.m1.com.sg""><Credential>{0}</Credential></AuthenticationSoapHeader></soap:Header><soap:Body><getRedemptionHistory xmlns=""http://www.m1.com.sg""><custId>{1}</custId><channelId>{2}</channelId><claimStatus>Y</claimStatus></getRedemptionHistory></soap:Body></soap:Envelope>";

        static public readonly string RedisConnectionSettings = "RedisConnectionSettings";

        static public readonly string BillingAccountsByAOUrl = "BillingAccountsByAOUrl";

        static public readonly string ServiceAccountsByAOUrl = "ServiceAccountsByAOUrl";

        static public readonly string BillingAccServiceLineByAOUrl = "BillingAccServiceLineByAOUrl";

        static public readonly string RetrieveAccessModuleUrl = "RetrieveAccessModuleUrl";

        static public readonly string RetrieveAccessModuleTypeUrl = "RetrieveAccessModuleTypeUrl";

        static public readonly string RetrieveAccessModuleClassUrl = "RetrieveAccessModuleClassUrl";

        static public readonly string RetrieveAccessSerivceUrl = "RetrieveAccessSerivceUrl";

        static public readonly string InsertAccessServiceUrl = "InsertAccessServiceUrl";

        static public readonly string UpdateAccessServiceUrl = "UpdateAccessServiceUrl";

        static public readonly string UploadAccessControlServiceUrl = "UploadAccessControlServiceUrl";

        static public readonly string GetServiceByAOUrl = "GetServicesByAO";

        static public readonly string NotificationCountJson = @"{{""NotificationCount"":""{0}""}}";

        static public readonly string InterceptorJson = @"""__interceptors"":[{}],";

        //Shared- Bill Transcation History
        static public readonly string RetrieveTransLog = "RetrieveTransLog";

        static public readonly string RetrieveC1PaymentTransUrl = "RetrieveC1PaymentTransUrl";

        static public readonly string GetPaymentHistoryUrl = "GetPaymentHistoryUrl";

        static public readonly string GetBillInfoUrl = "GetBillInfoUrl";

        static public readonly string InsertTransLog = "InsertTransLog";

        static public readonly string IN_CUST_ID = "IN_CUST_ID";

        static public readonly string IN_BILL_ACCOUNT = "IN_BILL_ACCOUNT";

        static public readonly string IN_MOBILE = "IN_MOBILE";

        static public readonly string IN_SERVICE_LINE_ITEM_ID = "IN_SERVICE_LINE_ITEM_ID";

        static public readonly string IN_AO_ID = "IN_AO_ID";

        static public readonly string IN_FROM_DATE = "IN_FROM_DATE";

        static public readonly string IN_TO_DATE = "IN_TO_DATE";

        static public readonly string IN_ACTION = "IN_ACTION";

        static public readonly string IN_ORDERID = "IN_ORDERID";

        static public readonly string IN_REMARKS = "IN_REMARKS";

        static public readonly string IN_ERRCD = "IN_ERRCD";

        static public readonly string IN_ERRMSG = "IN_ERRMSG";

        static public readonly string ErrorCode = "0";

        static public readonly string IN_BILL_ACCT = "IN_BILL_ACCT";
        static public readonly string PD_INDICATOR = "F";

        static public readonly string CONTRACT_INDICATOR = "F";

        static public readonly string PRODUCT_COMPONENT_REF_ID = "100000";

        static public readonly string ServicesText = "Service";

        static public readonly int NOTIFICATION_DISPLAY_CNT = 5;

        static public readonly int SOURCE_ID = 3;

        //Update consent

        static public readonly string CustomerID = "CustomerID";
        static public readonly string ServiceIdkey = "ServiceId";

        //Corporate SuspensionReactivation
        static public readonly string GetServicesWithReasonCodeByBA = "GetServicesWithReasonCodeByBA";

        static public readonly string GetServiceContactByBA = "GetServiceContactByBA";

        static public readonly string SetReasonReconnected = "SetReasonReconnected";

        static public readonly string SetReasonSuspended = "SetReasonSuspended";

        //Shared- Account Setting
        static public readonly string RetrieveBillingAccountInformation = "RetrieveBillingAccountInformation";

        static public readonly string RetrieveAccService = "RetrieveAccService";

        static public readonly string SetAccPrimaryService = "SetAccPrimaryService";

        //Corporate Account Dashboard
        static public readonly string GetOutstandingBillInfoByAOUrl = "GetOutstandingBillInfoByAOUrl";

        static public readonly string GetServiceContactByBAUrl = "GetServiceContactByBAUrl";

        static public readonly string GetSunperksPointsUrl = "GetSunperksPointsUrl";

        static public readonly string GetUpdateCustomerBillingProfileUrl = "GetUpdateCustomerBillingProfileUrl";

        static public readonly string GetContractDetailbyAOUrl = "GetContractDetailbyAOUrl";

        static public readonly string GetCustSvcDtlsWithNumberUrl = "GetCustSvcDtlsWithNumberUrl";

        static public readonly string RetrieveBillingAccountBalanceUrl = "RetrieveBillingAccountBalanceUrl";

        static public readonly string GetRecontractSurchargeUrl = "GetRecontractSurchargeUrl";

        static public readonly string SurchargeAmountUrl = "SurchargeAmountUrl";

        static public readonly string CheckHandsetUpgradeUrl = "CheckHandsetUpgradeUrl";

        static public readonly string GetMailAddresssUrl = "GetMailAddresssUrl";

        static public readonly string COMVERSE_BILLING_ACCT_NO = "COMVERSE_BILLING_ACCT_NO";

        static public readonly string CURRENT_INVOICE = "CURRENT_INVOICE";

        static public readonly string IN_ACCT_NO = "IN_ACCT_NO";

        static public readonly string GetOutstandingBillInfoByCAUrl = "GetOutstandingBillInfoByCAUrl";

        static public readonly string GetContractEndDateByServiceNoUrl = "GetContractEndDateByServiceNoUrl";

        static public readonly string maintainednominatedlineurl = "maintainednominatedlineurl";

        static public readonly string GetServicesByCAUrl = "GetServicesByCAUrl";

        static public readonly string Rewardssetting = "Rewardssetting";

        static public readonly string NotificationUploadMediaFolderGuid = "NotificationUploadMediaFolderGuid";

        static public readonly string GetServicesByCAKey = "ServicesByCA";
    }
}