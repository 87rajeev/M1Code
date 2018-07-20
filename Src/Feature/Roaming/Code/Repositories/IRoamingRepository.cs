using M1CP.Feature.Roaming.Models;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Feature.Roaming.Repositories
{
    public interface IRoamingRepository
    {
        ICountryDetails GetCountryDetails(Item item);

        ICountryList GetCountryList(Item item);

        IDataPassport GetDataPassportItems(Item item);

        IPackList GetPackItems(Item item);
    }
}
