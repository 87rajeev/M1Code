using M1CP.Feature.StockInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Feature.StockInformation.Repositories
{
    public interface IStockInformationQuotesRepository
    {
        Pricefeed GetStockInformationQuotes();
    }
}
