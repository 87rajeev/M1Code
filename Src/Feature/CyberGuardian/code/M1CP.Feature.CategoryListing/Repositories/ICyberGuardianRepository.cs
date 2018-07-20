using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using M1CP.Feature.CategoryListing.Models;

namespace M1CP.Feature.CategoryListing.Repositories
{
    public interface ICyberGuardianRepository
    {
        ICyberGuardianComponentSection GetSubCategoryItems(Item item);
    }
}