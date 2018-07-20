using Sitecore.Data.Items;
using M1CP.Feature.TableComponent.Models;
using M1CP.Foundation.DependencyInjection;
using M1CP.Foundation.Base.Repositories;

namespace M1CP.Feature.TableComponent.Repositories
{
    [Service(typeof(ITableRepository))]
    public class TableRepository : RepositoryBase, ITableRepository
    {
        public ITableList GetTableRows(Item item)
        {
            return ScContext.Cast<ITableList>(item);
        }
    }
}