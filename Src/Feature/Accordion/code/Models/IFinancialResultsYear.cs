using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;

namespace M1CP.Feature.Accordion.Models
{
    public interface IFinancialResultsYear
    {
        /// <summary>
        /// The Year field.
        /// <para></para>
        /// <para>Field Type: Number</para>		
        /// <para>Field ID: 3149820F-7967-41A3-B69E-3BE8B58D27E1</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.FinancialResultsYear.Fields.YearFieldName)]
        float Year { get; set; }

        [SitecoreChildren]
        IEnumerable<IFinancialResults> QuaterFinancialRelease { get; set; }

        IEnumerable<String> ListOfYears { get; set; }
    }
}
