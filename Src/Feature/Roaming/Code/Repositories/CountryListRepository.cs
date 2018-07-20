using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.DependencyInjection;
using Sitecore.Data.Items;
using M1CP.Feature.Roaming.Models;


namespace M1CP.Feature.Roaming.Repositories
{
    [Service(typeof(ICountryListRepository))]
    public class CountryListRepository: RepositoryBase,ICountryListRepository
    {
       
       

      }
}