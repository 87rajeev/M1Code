using M1CP.Feature.Banner.Models;
using Sitecore.Data.Items;
using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.DependencyInjection;


namespace M1CP.Feature.Banner.Repositories
{
    [Service(typeof(IBannerRepository))]
    public class BannerRepository : RepositoryBase, IBannerRepository
    {
        public IBannerModel GetBannerItems(Item item)
        {
            return ScContext.Cast<IBannerModel>(item);
        }

        public IPageBanner GetPageBannerItems(Item item)
        {
            return ScContext.Cast<IPageBanner>(item);
        }

        public HeroBannerWithLinks GetTopBannerWithLinks(Item item)
        {
            return ScContext.Cast<HeroBannerWithLinks>(item);
        }
        public IBannerWithoutCTA GetTopBannerWithoutCTA(Item item)
        {
            return ScContext.Cast<IBannerWithoutCTA>(item);
        }
    }
}