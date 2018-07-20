namespace M1CP.Foundation.Indexing.Repositories
{
    using M1CP.Foundation.DependencyInjection;
    using M1CP.Foundation.Indexing.Models;
    using M1CP.Foundation.Indexing.Services;

    [Service(typeof(ISearchServiceRepository))]
    public class SearchServiceRepository : ISearchServiceRepository
    {
        public virtual SearchService Get(ISearchSettings settings)
        {
            return new SearchService(settings);
        }
    }
}