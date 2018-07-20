using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using M1CP.Foundation.Base.Models;
 

namespace M1CP.Feature.AnnualReports.Models
{
    public interface IAnnualReports
    {
        [SitecoreField(Templates.AnnualReportListConstants.Fields.SelectAnnualReportsFieldName)]
          IEnumerable<AnnualReportByDates> Select__Annual_Reports { get; set; }
    }

    [SitecoreType(TemplateId = Templates.AnnualReportByDatesConstants.TemplateIdString)] //, Cachable = true
    public   class AnnualReportByDates :GlassBase
    {


        /// <summary>
        /// The Annual Report PDF field.
        /// <para></para>
        /// <para>Field Type: General Link</para>		
        /// <para>Field ID: 59f7e3a6-3684-41b3-81c8-7c3871473a94</para>
        /// <para>Custom Data: </para>
        /// </summary>
      
        [SitecoreField(Templates.AnnualReportByDatesConstants.Fields.Annual_Report_PDFFieldName)]
        public virtual Link Annual_Report_PDF { get; set; }


        /// <summary>
        /// The Images field.
        /// <para></para>
        /// <para>Field Type: Image</para>		
        /// <para>Field ID: 90367a34-a5a9-4728-bfe8-355abd93e866</para>
        /// <para>Custom Data: </para>
        /// </summary>
 
        [SitecoreField(Templates.AnnualReportByDatesConstants.Fields.ImagesFieldName)]
        public virtual Image Images { get; set; }


        /// <summary>
        /// The Notice Of AGDM PDF field.
        /// <para></para>
        /// <para>Field Type: General Link</para>		
        /// <para>Field ID: 95f90df4-fd4b-4342-a27b-2d74bd53ff7a</para>
        /// <para>Custom Data: </para>
        /// </summary>
      
        [SitecoreField(Templates.AnnualReportByDatesConstants.Fields.Notice_Of_AGDM_PDFFieldName)]
        public virtual Link Notice_Of_AGDM_PDF { get; set; }


        /// <summary>
        /// The Year field.
        /// <para></para>
        /// <para>Field Type: Single-Line Text</para>		
        /// <para>Field ID: 61e794c7-847e-4a75-8259-2a3c0231963a</para>
        /// <para>Custom Data: </para>
        /// </summary>
    
        [SitecoreField(Templates.AnnualReportByDatesConstants.Fields.YearFieldName)]
        public virtual string Year { get; set; }


    }

 
   

}
