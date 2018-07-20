using M1CP.Feature.StockInformation.Models;
using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.DependencyInjection;
using Sitecore.Data.Items;


namespace M1CP.Feature.StockInformation.Repositories
{
    [Service(typeof(IStockInformationRepository))]
    public class StockInformationRepository : RepositoryBase, IStockInformationRepository
    {
        public IStockInformation GetStockInformationItems(Item item)
        {
            return ScContext.Cast<IStockInformation>(item);
        }
    }
}