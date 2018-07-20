namespace M1CP.Feature.Navigation
{
    public static class Constants
    {
        public static class Views
        {
            public const string MainNavigation = "~/Views/M1CP/Navigation/Navigation.cshtml";
            public const string FooterNavigation = "~/Views/M1CP/Navigation/PageFooter.cshtml";
            public const string LeftNavigation = "~/Views/M1CP/Navigation/TopLeftNavigation.cshtml";
            public const string RightNavigation = "~/Views/M1CP/Navigation/TopRightNavigation.cshtml";
            public const string Navbar = "~/Views/M1CP/Navigation/navbar.cshtml";
            public const string SiteIdentify = "~/Views/M1CP/Navigation/SiteIdentity.cshtml";
            public const string BreadCrumb = "~/Views/M1CP/BreadCrumb/BreadCrumb.cshtml";
        }

        public static class Property
        {
            public const string MainNavigationCacheKey = "MainNavigationCacheKey";
            public const string PersonalNavigationCacheKey = "PersonalNavigationCacheKey";
            public const string BusinessNavigationCacheKey = "BusinessNavigationCacheKey";
            public const string FooterNavigationCacheKey   = "FooterNavigationCacheKey";
            public const string LeftNavigationCachekey = "LeftNavigationCacheKey";
            public const string RightNavigationCachekey = "RightNavigationCachekey";
            public const string BreadCrumbCacheKey = "BreadCrumbCachekey";
            public const int Duration = 3600;
        }

        public static class Placeholder
        {

            public const string LeftNaviation = "navbar-left";
            public const string CenterNavigation = "navbar-center";
            public const string rightNavigation = "navbar-right";
        }

        public static class RenderingItemIDs
        {
            public const string Logo = "{DBCA9622-D5E9-4B18-8290-FAC559F02C97}";
            public const string BreadcrumbId = "{D558BDA5-AEE2-4950-A589-E46A895341B5}";
        }         

    }
}