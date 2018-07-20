using System;
using System.Collections.Generic;
using System.Linq;
using M1CP.Feature.Navigation.Models;
using M1CP.Foundation.Base.Models;
using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.DependencyInjection;
using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace M1CP.Feature.Navigation.Repositories
{
   [Service(typeof(INavigationRepository))]
    public class NavigationRepository : RepositoryBase, INavigationRepository
    {
        /// <summary>
        /// Gets the navigation links.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public NavigationGroup GetNavigationLinks(Item item)
        {
            return ScContext.Cast<NavigationGroup>(item);
        }

        public Guid? FindAncestorPage(IEnumerable<IGlassBase> items, Func<IGlassBase, Guid?> targetResolver)
        {
            if (items.Any())
            {
                // Take the links and use the targetResolver to get a collection of items than can then
                // be sorted by path length, longest first.
                var targetItems = items.Select(targetResolver)
                    .Where(guid => guid.HasValue && guid != Guid.Empty)
                    .Select(id => ScContext.GetItem<IGlassBase>(id.Value))
                    .Where(item => item != null)
                    .OrderByDescending(item => item.Path.Length);

                var currentContextPath = StringUtil.EnsurePostfix('/', RenderingContext.Current.PageContext.Item.Paths.FullPath);

                foreach (var item in targetItems)
                {
                    if (currentContextPath.StartsWith(StringUtil.EnsurePostfix('/', item.Path), StringComparison.InvariantCultureIgnoreCase))
                    {
                        return item.Id;
                    }
                }
            }

            return null;
        }


        public List<URLDetails> GetBreadCrumb(Item CurrentItem)
        {
            List<URLDetails> BreadCrumb = new List<URLDetails>();
            IBreadCrumb BreadCrumbItem = ScContext.Cast<IBreadCrumb>(Sitecore.Context.Database.GetItem(Constants.RenderingItemIDs.BreadcrumbId));
            var BreadCrumbRestriction = BreadCrumbItem.SitecoreID.Split(',');
            if (CurrentItem != null)
            {

                URLDetails UrlObj = new URLDetails();
                UrlObj.LinkName = ScContext.Cast<IBreadCrumbInfo>(CurrentItem).BreadCrumbTitle;
                UrlObj.LinkURL = Sitecore.Links.LinkManager.GetItemUrl(CurrentItem);
                BreadCrumb.Add(UrlObj);


                Item Parent = CurrentItem.Parent;

                while (!BreadCrumbRestriction.Contains(Parent.TemplateID.ToString()))
                {
                    var TempItem = Parent;
                    UrlObj = new URLDetails();
                    UrlObj.LinkName = ScContext.Cast<IBreadCrumbInfo>(TempItem).BreadCrumbTitle;
                    UrlObj.LinkURL = Sitecore.Links.LinkManager.GetItemUrl(TempItem);
                    BreadCrumb.Add(UrlObj);
                    Parent = TempItem.Parent;
                }
                BreadCrumb.Reverse();
            }
            return BreadCrumb;
        }


    }
}