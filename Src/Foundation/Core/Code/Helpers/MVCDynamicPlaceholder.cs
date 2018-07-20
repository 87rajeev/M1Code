using Sitecore.Configuration;
using Sitecore.Mvc.Helpers;
//using SitecoreExperienced.SitecoreControls;
using System.Collections.Generic;
using System.Globalization;
using System.Web;

public static class MVCDynamicPlaceholder
{
    private static string placeholderPattern = Settings.GetSetting("DynamicPlaceholderPattern");

    private static List<string> DynamicPlaceholderList
    {
        get
        {
            return (List<string>)HttpContext.Current.Items["DynamicPlaceholders"];
        }
        set
        {
            HttpContext.Current.Items["DynamicPlaceholders"] = value;
        }
    }

    /// <summary>
    /// To get dynamic placeholder key
    /// </summary>
    /// <param name="myScHelper"></param>
    /// <param name="placeholderName"></param>
    /// <returns></returns>
    public static HtmlString DynamicPlaceholder(this SitecoreHelper myScHelper, string placeholderName)
    {
        
        if (MVCDynamicPlaceholder.DynamicPlaceholderList == null)
        {
            MVCDynamicPlaceholder.DynamicPlaceholderList = new List<string>();
        }
        string dynamicPlaceholderKey = MVCDynamicPlaceholder.GetDynamicPlaceholderKey(placeholderName);
        if (!string.IsNullOrWhiteSpace(dynamicPlaceholderKey))
        {
            placeholderName = dynamicPlaceholderKey;
        }
        MVCDynamicPlaceholder.DynamicPlaceholderList.Add(placeholderName);
        return myScHelper.Placeholder(placeholderName);
    }

    /// <summary>
    /// Generate dynamic key based on logic
    /// </summary>
    /// <param name="placeholderName"></param>
    /// <returns></returns>
    private static string GetDynamicPlaceholderKey(string placeholderName)
    {
        bool flag = false;
        int num = 0;
        foreach (string dynamicPlaceholder in MVCDynamicPlaceholder.DynamicPlaceholderList)
        {
            if (placeholderName == dynamicPlaceholder || dynamicPlaceholder.StartsWith(placeholderName + MVCDynamicPlaceholder.placeholderPattern))
            {
                flag = true;
                num++;
            }
        }
        if (flag)
        {
            placeholderName = placeholderName + MVCDynamicPlaceholder.placeholderPattern + num.ToString(CultureInfo.InvariantCulture);
        }
        return placeholderName;
    }
}
