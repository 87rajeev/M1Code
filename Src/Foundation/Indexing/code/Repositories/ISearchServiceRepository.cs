namespace M1CP.Foundation.Indexing.Repositories
{
    using M1CP.Foundation.Indexing.Models;
    using M1CP.Foundation.Indexing.Services;

    public interface ISearchServiceRepository
    {
        SearchService Get(ISearchSettings searchSettings);
    }
}