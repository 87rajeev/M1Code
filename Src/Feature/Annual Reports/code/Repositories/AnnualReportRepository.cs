using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using M1CP.Feature.AnnualReports.Models;
using M1CP.Foundation.Base.Repositories;
 
using M1CP.Foundation.DependencyInjection;
using Sitecore.Data.Items;

namespace M1CP.Feature.AnnualReports.Repositories
{
    [Service(typeof(IAnnualReportRepository))]
    public class AnnualReportRepository : RepositoryBase,IAnnualReportRepository
    {
        public InvestorContentPage GetReportByDates(Item item)
        {
            return ScContext.Cast<InvestorContentPage>(item);
        }
    }
}