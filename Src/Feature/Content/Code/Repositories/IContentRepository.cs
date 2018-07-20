using M1CP.Feature.Content.Models;
using Sitecore.Data.Items;


namespace M1CP.Feature.Content.Repositories
{
    public interface IContentRepository
    {
        IContent GetContent(Item item);
        IImageContent GetImageContent(Item item);
    }
}
