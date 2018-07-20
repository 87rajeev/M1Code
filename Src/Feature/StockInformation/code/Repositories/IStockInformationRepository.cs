using M1CP.Feature.StockInformation.Models;
using Sitecore.Data.Items;


namespace M1CP.Feature.StockInformation.Repositories
{
    /// <summary>
    /// IStockInformationRepository
    /// </summary>
    public interface IStockInformationRepository
    {
        IStockInformation GetStockInformationItems(Item item);
    }
}
