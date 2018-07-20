using M1CP.Feature.FAQ.Models;
using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.DependencyInjection;
using Sitecore.Data.Items;

namespace M1CP.Feature.FAQ.Repositories
{
    [Service(typeof(IFAQRepository))]
    public class FAQRepository : RepositoryBase, IFAQRepository
    {
        /// <summary>
        /// Get FAQ Items
        /// </summary>
        /// <param name="item">Current Item</param>
        /// <returns>IFAQGroup model</returns>
        public IFAQGroup GetFAQItems(Item item)
        {
            return ScContext.Cast<IFAQGroup>(item);
        }
        
    }
}