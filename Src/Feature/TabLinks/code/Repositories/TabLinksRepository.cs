using M1CP.Feature.TabLinks.Models;
using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.DependencyInjection;
using Sitecore.Data.Items;

namespace M1CP.Feature.TabLinks.Repositories
{
    [Service(typeof(ITabLinksRepository))]
    public class TabLinksRepository : RepositoryBase,ITabLinksRepository
    {
        public ITabLink GetTabLinkItems(Item item)
            {
                return ScContext.Cast<ITabLink>(item);
            }
        
    }
}