using M1CP.Feature.Navigation.Models;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using M1CP.Foundation.Base.Models;

namespace M1CP.Feature.Navigation.Repositories
{
    public interface INavigationRepository  
    {
        NavigationGroup GetNavigationLinks(Item item);
        Guid? FindAncestorPage(IEnumerable<IGlassBase> items, Func<IGlassBase, Guid?> targetResolver);

        List<URLDetails> GetBreadCrumb(Item CurrentItem);
    }
}
