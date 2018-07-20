using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.Base.Models;


namespace M1CP.Feature.AnnualReports.Models
{
    [SitecoreType(AutoMap = true)]
    //[SitecoreType(TemplateId = Templates.InvestorContentPageConstants.TemplateIdString)] //, Cachable = true
    public class InvestorContentPage : GlassBase
    {
        
        /// <summary>
        /// The Select  Annual Reports field.
        /// <para></para>
        /// <para>Field Type: Treelist</para>		
        /// <para>Field ID: 35281d39-dd5e-4e34-977f-19c79faa6739</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.InvestorContentPageConstants.Fields.Select__Annual_ReportsFieldName)]
        public virtual IEnumerable<AnnualReportByDates> Select__Annual_Reports { get; set; }


    }
}