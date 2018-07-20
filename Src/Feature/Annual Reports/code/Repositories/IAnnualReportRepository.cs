using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M1CP.Feature.AnnualReports.Models;
using Sitecore.Data.Items;

namespace M1CP.Feature.AnnualReports.Repositories
{
    public interface IAnnualReportRepository
    {
        InvestorContentPage GetReportByDates(Item item);
    }
}
