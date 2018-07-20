namespace M1CP.Foundation.Indexing.Services
{
    using Sitecore.ContentSearch;
    using M1CP.Foundation.DependencyInjection;

    [Service]
    public class SearchIndexResolver
    {
        public virtual ISearchIndex GetIndex(SitecoreIndexableItem contextItem)
        {
            return ContentSearchManager.GetIndex(contextItem);
        }
    }
}