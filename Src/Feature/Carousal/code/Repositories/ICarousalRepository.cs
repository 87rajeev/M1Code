using M1CP.Feature.Carousal.Models;
using Sitecore.Data.Items;

namespace M1CP.Feature.Carousal.Repositories
{
    public interface ICarousalRepository
    {
        ICarousal GetCarousalItems(Item item);

        IDeviceCarousal GetDeviceCarousalItems(Item item);
    }
}
