using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.DependencyInjection;
using Sitecore.Data.Items;
using M1CP.Feature.Roaming.Models;

namespace M1CP.Feature.Roaming.Repositories
{
    [Service(typeof(IRoamingRepository))]
    public class RoamingRepository: RepositoryBase,IRoamingRepository
    {
        public ICountryDetails GetCountryDetails(Item item)
        {
            return ScContext.Cast<ICountryDetails>(item);
        }

        public ICountryList GetCountryList(Item item)
        {
            return ScContext.Cast<ICountryList>(item);
        }

        public IDataPassport GetDataPassportItems(Item item)
        {
            return ScContext.Cast<IDataPassport>(item);
        }

        public IPackList GetPackItems(Item item)
        {
            var model = ScContext.Cast<IPackList>(item);
            Item i = ScContext.GetItem<Item>(model.packList.First().Path).Parent;
            var packModel = ScContext.Cast<IPackInfo>(i);
            model.packIcon = packModel.packIcon;
            model.packTitle = packModel.packTitle;                                 
            return model;
        }

    }
}