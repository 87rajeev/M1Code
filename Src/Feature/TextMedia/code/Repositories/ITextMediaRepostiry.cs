namespace M1CP.Feature.TextMedia.Repositories
{
    public interface ITextMediaRepostiry
    {
        TextMedia.Models.TextMediaModelList GetMediaModelList(Sitecore.Data.Items.Item item);
    }
}