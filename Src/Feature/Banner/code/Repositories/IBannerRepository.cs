using M1CP.Feature.Banner.Models;
using Sitecore.Data.Items;
namespace M1CP.Feature.Banner.Repositories
{
    public interface IBannerRepository
    {
        IBannerModel GetBannerItems(Item item);

        IPageBanner GetPageBannerItems(Item item);

        HeroBannerWithLinks GetTopBannerWithLinks(Item item);

        IBannerWithoutCTA GetTopBannerWithoutCTA(Item item);
    }
}