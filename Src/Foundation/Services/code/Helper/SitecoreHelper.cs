using Sitecore;
using Sitecore.Configuration;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace M1CP.Foundation.Services.Helper
{
    public class SitecoreHelper
    {
        private static Database masterDB = Factory.GetDatabase("master");

        /// <summary>
        /// Gets the current Database.
        /// </summary>
        public static Database ContextDatabase
        {
            get
            {
                return Context.Database ?? Factory.GetDatabase("web");
            }
        }

        public static Database ContextDatabaseWeb
        {
            get
            {
                return Factory.GetDatabase("web");
            }
        }
        public static Item GetSitecoreItemByPath(string itemPath)
        {
            Item currentItem = null;
            if (!string.IsNullOrEmpty(itemPath))
            {
                currentItem = ContextDatabase.GetItem(itemPath);
            }
            return currentItem;
        }

        public static Item GetSitecoreItemById(string id)
        {
            Item currentItem = null;
            if (!string.IsNullOrEmpty(id))
            {
                currentItem = ContextDatabaseWeb.GetItem(id, Context.Language);
            }
            return currentItem;
        }

    }
}