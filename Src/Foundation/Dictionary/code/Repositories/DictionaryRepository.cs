using System;
using System.Configuration;
using Sitecore.Data.Items;
using M1CP.Foundation.Dictionary.Models;
using Sitecore.Sites;

namespace M1CP.Foundation.Dictionary.Repositories
{
    public class DictionaryRepository: IDictionaryRepository
    {
        private const string MasterDatabaseName = "master";

        public static M1CP.Foundation.Dictionary.Models.Dictionary Current => new DictionaryRepository().Get(SiteContext.Current);

        public M1CP.Foundation.Dictionary.Models.Dictionary Get(SiteContext site)
        {
            return new M1CP.Foundation.Dictionary.Models.Dictionary()
            {
                Site = site,
                AutoCreate = this.GetAutoCreateSetting(site),
                Root = this.GetDictionaryRoot(site),
            };
        }

        private Item GetDictionaryRoot(SiteContext site)
        {
            var dictionaryPath = site.Properties["dictionaryPath"]; //Set Properties to Site
            if (dictionaryPath == null)
                throw new ConfigurationErrorsException("No dictionaryPath was specified on the <site> definition.");
            var rootItem = site.Database.GetItem(dictionaryPath);
            if (rootItem == null)
                throw new ConfigurationErrorsException("The root item specified in the dictionaryPath on the <site> definition was not found.");
            return rootItem;
        }

        private bool GetAutoCreateSetting(SiteContext site)
        {
            var autoCreateSetting = site.Properties["dictionaryAutoCreate"];
            if (autoCreateSetting == null)
                return false;
            bool autoCreate;
            if (!bool.TryParse(autoCreateSetting, out autoCreate))
                return false;
            return autoCreate && (site.Database.Name.Equals(MasterDatabaseName, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}