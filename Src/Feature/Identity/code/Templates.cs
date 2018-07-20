using Sitecore.Data;

namespace M1CP.Feature.Identity
{
    public struct Templates
    {
        /// <summary>
        /// Template of Site item
        /// </summary>
        public struct Site
        {
            public struct Fields
            {
                public const string FavIconFieldName = "Fav icon";
                public const string Path = "/sitecore/content/M1/CorporatePortal";
                public static readonly ID FavIconFieldId = new ID("2d187a5f-e0c5-4052-bab9-32d2db1cc2e4");
            }
        }
    }
}