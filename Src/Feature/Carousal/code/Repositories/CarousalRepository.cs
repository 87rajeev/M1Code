using M1CP.Feature.Carousal.Models;
using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.DependencyInjection;
using Sitecore.Data.Items;

namespace M1CP.Feature.Carousal.Repositories
{
    [Service(typeof(ICarousalRepository))]
    public class CarousalRepository: RepositoryBase, ICarousalRepository
    {
        public ICarousal GetCarousalItems(Item item)
        {
            return ScContext.Cast<ICarousal>(item);
        }

        public IDeviceCarousal GetDeviceCarousalItems(Item item)
        {
            return ScContext.Cast<IDeviceCarousal>(item);
        }
    }
}