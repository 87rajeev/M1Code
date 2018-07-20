using M1CP.Feature.IFrame.Models;
using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.DependencyInjection;
using Sitecore.Data.Items;


namespace M1CP.Feature.IFrame.Repositories
{
    [Service(typeof(IIFrameRepository))]
    public class IFrameRepository : RepositoryBase , IIFrameRepository
    {
        public IIFrame GetIFrameItems(Item item)
        {
            return ScContext.Cast<IIFrame>(item);
        }
    }
}