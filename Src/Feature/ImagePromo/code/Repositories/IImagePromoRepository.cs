using M1CP.Feature.ImagePromo.Models;
using Sitecore.Data.Items;

namespace M1CP.Feature.ImagePromo.Repositories
{
    /// <summary>
    /// IImagePromoRepository
    /// </summary>
    public interface IImagePromoRepository
    {        
        IImagePromoInfo GetImagePromoItems(Item item);
    }
}
