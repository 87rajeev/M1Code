#region

using Sitecore.Configuration;

#endregion

namespace M1CP.Feature.Sitemap
{
    public struct Constants
    {
        /// <summary>
        /// The default values support the Sitemap Page Settings template fields.
        /// These values can be overriden using the Sitemap.Fields.* setting values in 
        /// the SitemapXML.config configuration file.
        /// </summary>
        public struct SeoSettings
        {
            public static string Title = Settings.GetSetting("Sitemap.Fields.Title", "Sitemap Title");
            public static string Priority = Settings.GetSetting("Sitemap.Fields.Priority", "Priority");
            public static string ChangeFrequency = Settings.GetSetting("Sitemap.Fields.ChangeFrequency", "Change Frequency");
        }

        public struct SharedContent
        {
            public static string ParentItemFieldName = "Parent Item";
            public static string ContentLocationFieldName = "Content Location";
        }

        public struct WebsiteDefinition
        {
            public static string SearchEnginesFieldName = "Search Engines";
            public static string EnabledTemplatesFieldName = "Enabled Templates";
            public static string ExcludedItemsFieldName = "Excluded Items";
            public static string FileNameFieldName = "File Name";
            public static string ServerUrlFieldName = "Server Url";
            public static string CleanupBucketPath = "Cleanup Bucket Path";
            public static string SiteRobotsTxt = "Site Robots Txt";
        }

        public static string SitemapParserUser = @"extranet\Anonymous";
        public static string SitemapModuleSettingsRootItemId = "{0C974E5E-6080-4128-B12A-1D3B4AC06397}";
        public static string RobotsFileName = "robots.txt";
        public static string SitemapSubmissionUriFieldName = "Sitemap Submission Uri";
    }
}