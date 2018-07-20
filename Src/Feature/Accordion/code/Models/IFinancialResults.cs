using Glass.Mapper.Sc.Configuration.Attributes;
using System.Collections.Generic;

namespace M1CP.Feature.Accordion.Models
{
    public interface IFinancialResults
    {
        /// <summary>
        /// The Year field.
        /// <para></para>
        /// <para>Field Type: Number</para>		
        /// <para>Field ID: 105B4388-B073-4BB6-A599-A09402373D95</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.FinancialResults.Fields.YearFieldName)]
        float Year { get; set; }

        /// <summary>
        /// The Quater field.
        /// <para></para>
        /// <para>Field Type: Drop List</para>		
        /// <para>Field ID: AA2A7983-24D1-4363-8EFB-F51AF1977E6A</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.FinancialResults.Fields.QuarterFieldName)]
        string Quater { get; set; }


        /// <summary>
        /// The Quater Result Title field.
        /// <para></para>
        /// <para>Field Type: Single Line Text</para>		
        /// <para>Field ID: 23D0FB2A-7C4D-4366-8A25-936239D2FE51</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.FinancialResults.Fields.QuarterResultTitleFieldName)]
        string QuarterResultTitle { get; set; }


        [SitecoreChildren]
        IEnumerable<IFinancialReleaseFiles> QuaterFinancialRelease { get; set; }

    }
}
