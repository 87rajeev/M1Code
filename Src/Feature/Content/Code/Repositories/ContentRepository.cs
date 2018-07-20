using M1CP.Feature.Content.Models;
using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.DependencyInjection;
using Sitecore.Data.Items;

namespace M1CP.Feature.Content.Repositories
{
    [Service(typeof(IContentRepository))]
    public class ContentRepository :RepositoryBase, IContentRepository
    {
      public IContent GetContent(Item item)
        {
            return ScContext.Cast<IContent>(item);
        }
       public IImageContent GetImageContent(Item item)
        {
            return ScContext.Cast<IImageContent>(item);
        }
    }
}