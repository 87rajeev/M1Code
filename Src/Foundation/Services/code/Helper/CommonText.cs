using M1CP.Foundation.Services.Constants;
using Sitecore.Configuration;
using Sitecore.Xml;
using System.Collections.Generic;
using System.Xml;

namespace M1CP.Foundation.Services.Helper
{
    public class CommonText
    {
        public static string GetGenericConstant(string itemKey)
        {
            if (string.IsNullOrEmpty(itemKey))
                return string.Empty;
            return GetConfigurationEntryValueByKey(itemKey, ServiceConstants.GenericConstantConfigNodePath);
        }

        public static string GetItemPathConstant(string itemKey)
        {
            if (string.IsNullOrEmpty(itemKey))
                return string.Empty;
            return GetConfigurationEntryValueByKey(itemKey, ServiceConstants.ItemPathConfigNodePath);
        }

        public static string GetItemGuidConstant(string itemKey)
        {
            if (string.IsNullOrEmpty(itemKey))
                return string.Empty;
            return GetConfigurationEntryValueByKey(itemKey, ServiceConstants.ItemGuidConfigNodePath);
        }

        private static string GetConfigurationEntryValueByKey(string key, string nodeXPath)
        {
            Dictionary<string, string> itemsConfigEntries = GetConfigurationEntryCollectionByKey(nodeXPath);
            return itemsConfigEntries != null && itemsConfigEntries.ContainsKey(key) ? itemsConfigEntries[key] : string.Empty;
        }

        private static Dictionary<string, string> GetConfigurationEntryCollectionByKey(string nodeXPath)
        {
            var templatesConfigEntries = new Dictionary<string, string>();
            using (XmlNodeList nodeList = Factory.GetConfigNodes(nodeXPath))
            {
                foreach (XmlNode node in nodeList)
                {
                    if (!templatesConfigEntries.ContainsKey(XmlUtil.GetAttribute(ServiceConstants.ConfigNodeAttributeKey, node)))
                    {
                        templatesConfigEntries.Add(XmlUtil.GetAttribute(ServiceConstants.ConfigNodeAttributeKey, node), XmlUtil.GetAttribute(ServiceConstants.ConfigNodeAttributeValue, node));
                    }
                }

                return templatesConfigEntries;
            }
        }
    }
}