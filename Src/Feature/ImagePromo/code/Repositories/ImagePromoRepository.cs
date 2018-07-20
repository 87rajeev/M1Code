using M1CP.Feature.ImagePromo.Models;
using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.DependencyInjection;
using Sitecore.Data.Items;

namespace M1CP.Feature.ImagePromo.Repositories
{
    [Service(typeof(IImagePromoRepository))]
    public class ImagePromoRepository : RepositoryBase , IImagePromoRepository
    {
        public IImagePromoInfo GetImagePromoItems(Item item)
        {
            return ScContext.Cast<IImagePromoInfo>(item);
        }
    }
}