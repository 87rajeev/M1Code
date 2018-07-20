using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M1CP.Feature.TableComponent.Models;

namespace M1CP.Feature.TableComponent.Repositories
{
 public interface ITableRepository
    {
        ITableList GetTableRows(Item item);
       
    }
}
