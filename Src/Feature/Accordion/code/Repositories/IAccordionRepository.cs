using M1CP.Feature.Accordion.Models;
using Sitecore.Data.Items;

namespace M1CP.Feature.Accordion.Repositories
{
    public interface IAccordionRepository
    {
        /// <summary>
        /// Get Thumbnail Items based on year
        /// </summary>
        /// <param name="current"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IFinancialResultsYear GetAccordionThumbnailItems(Item current,float year);
    }
}