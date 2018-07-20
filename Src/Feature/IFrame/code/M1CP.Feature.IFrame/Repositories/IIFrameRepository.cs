using M1CP.Feature.IFrame.Models;
using Sitecore.Data.Items;

namespace M1CP.Feature.IFrame.Repositories
{
    public interface IIFrameRepository
    {
        IIFrame GetIFrameItems(Item item);
    }
}
