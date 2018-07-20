using M1CP.Feature.FAQ.Models;
using Sitecore.Data.Items;

namespace M1CP.Feature.FAQ.Repositories
{    
    public interface IFAQRepository
    {
        /// <summary>
        /// Get FAQ Items
        /// </summary>
        /// <param name="item">Current Item</param>
        /// <returns>IFAQGroup Model</returns>
        IFAQGroup GetFAQItems(Item item);
    }
}