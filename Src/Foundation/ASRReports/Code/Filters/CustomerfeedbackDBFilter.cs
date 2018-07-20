// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-17-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-20-2018
// ***********************************************************************
// <copyright file="CustomerfeedbackDBFilter.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using ASR.Interface;
using M1CP.Foundation.ASRReports.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.ASRReports.Filters
{
    /// <summary>
    /// Class CustomerfeedbackDBFilter.
    /// </summary>
    /// <seealso cref="ASR.Interface.BaseFilter" />
    public class CustomerfeedbackDBFilter : BaseFilter
    {
        /// <summary>
        /// Filter for the from Date
        /// </summary>
        /// <value>From date.</value>
        public DateTime FromDate { get; set; }
        /// <summary>
        /// Filter for To date
        /// </summary>
        /// <value>To date.</value>
        public DateTime ToDate { get; set; }

        /// <summary>
        /// Filter the result and get the values by applying filter.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public override bool Filter(object element)
        {
            var logElement = element as CustomerfeedbackDB;
            DateTime dateCreated = Convert.ToDateTime(logElement.CreateDate);

            if (FromDate<=dateCreated.Date && dateCreated.Date<= ToDate)
                {
                    return true;
                }
                return false;
        }
    }
}