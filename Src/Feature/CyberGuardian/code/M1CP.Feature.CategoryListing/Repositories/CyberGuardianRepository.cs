using M1CP.Foundation.Base.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using M1CP.Feature.CategoryListing.Models;
using Sitecore.Data.Items;
using M1CP.Foundation.DependencyInjection;
namespace M1CP.Feature.CategoryListing.Repositories
{
    [Service(typeof(ICyberGuardianRepository))]
    public class CyberGuardianRepository : RepositoryBase, ICyberGuardianRepository
    {
        /// <summary>
        /// GetSubCategoryItems
        /// </summary>
        /// <param name="item">Category items</param>
        /// <returns></returns>
        public ICyberGuardianComponentSection GetSubCategoryItems(Item item)
        {
            return ScContext.Cast<ICyberGuardianComponentSection>(item);
        }
    }
}