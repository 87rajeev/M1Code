using Sitecore.Data.Items;
using M1CP.Feature.Thumbnail.Models;

namespace M1CP.Feature.Thumbnail.Repositories
{
    public interface IThumbnailRepository
    { 
        IThumbnailGroup GetThumnailItems(Item item);

        IThumbnailSection GetThumbnailItems(Item item);

        IDeviceThumbnail GetDeviceThumbnailItems(Item item);

        IThumbnailGroup GetGradientThumnailItems(Item item);

        IThumbnailIcon GetThumbnailicons(Item item);
    }
}