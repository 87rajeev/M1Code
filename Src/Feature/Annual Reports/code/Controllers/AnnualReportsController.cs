using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using M1CP.Feature.AnnualReports.Repositories;
using M1CP.Foundation.Base.Controllers;


namespace M1CP.Feature.AnnualReports.Controllers
{
    public class AnnualReportsController : BaseController
    {
        // GET: AnnualReports
        private IAnnualReportRepository _annualReport;
        public AnnualReportsController(IAnnualReportRepository annualReport)
        {
            _annualReport = annualReport;
        }
        public ActionResult Reports()
        {
            var model=   _annualReport.GetReportByDates(CurrentItem);
            return PartialOrEmpty(Constants.Views.AnnualReports, model);
        }
    }
}