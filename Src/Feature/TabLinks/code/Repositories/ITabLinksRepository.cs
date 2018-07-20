using Sitecore.Data.Items;
using M1CP.Feature.TabLinks.Models;

namespace M1CP.Feature.TabLinks.Repositories
{
    public interface ITabLinksRepository
    {
        ITabLink GetTabLinkItems(Item item);
     
    }
}
