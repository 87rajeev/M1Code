using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.DependencyInjection;
using Sitecore.Data.Items;
using M1CP.Feature.Thumbnail.Models;

namespace M1CP.Feature.Thumbnail.Repositories
{
    [Service(typeof(IThumbnailRepository))]
    public class ThumbnailRepository: RepositoryBase, IThumbnailRepository
    {
        public IThumbnailGroup GetThumnailItems(Item item)
        {
            return ScContext.Cast<IThumbnailGroup>(item);
        }

        public IThumbnailGroup GetGradientThumnailItems(Item item)
        {
            return ScContext.Cast<IThumbnailGroup>(item);
        }

        public IThumbnailSection GetThumbnailItems(Item item)
        {
            return ScContext.Cast<IThumbnailSection>(item);
        }

        public IDeviceThumbnail GetDeviceThumbnailItems(Item item)
        {
            return ScContext.Cast<IDeviceThumbnail>(item);
        }
        public IThumbnailIcon GetThumbnailicons(Item item)
        {
            return ScContext.Cast<IThumbnailIcon>(item);
        }

    }
}
