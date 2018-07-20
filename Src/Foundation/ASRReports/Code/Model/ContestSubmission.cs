// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-20-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-20-2018
// ***********************************************************************
// <copyright file="ContestSubmission.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace M1CP.Foundation.ASRReports.Model
{

    /// <summary>
    /// Class ContestSubmission.
    /// </summary>
    public partial class ContestSubmission
    {
        /// <summary>
        /// Gets or sets the m1 identifier.
        /// </summary>
        /// <value>The m1 identifier.</value>
        public string M1ID { get; set; }
        /// <summary>
        /// Gets or sets the name of the campaign.
        /// </summary>
        /// <value>The name of the campaign.</value>
        public string CampaignName { get; set; }
        /// <summary>
        /// Gets or sets the nric.
        /// </summary>
        /// <value>The nric.</value>
        public string NRIC { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the contactnumber.
        /// </summary>
        /// <value>The contactnumber.</value>
        public Decimal Contactnumber { get; set; }
        /// <summary>
        /// Gets or sets the contest answer.
        /// </summary>
        /// <value>The contest answer.</value>
        public string ContestAnswer { get; set; }
        /// <summary>
        /// Gets or sets the value1.
        /// </summary>
        /// <value>The value1.</value>
        public string Value1 { get; set; }
        /// <summary>
        /// Gets or sets the value2.
        /// </summary>
        /// <value>The value2.</value>
        public string Value2 { get; set; }
        /// <summary>
        /// Gets or sets the value3.
        /// </summary>
        /// <value>The value3.</value>
        public string Value3 { get; set; }
        /// <summary>
        /// Gets or sets the value4.
        /// </summary>
        /// <value>The value4.</value>
        public string Value4 { get; set; }
        /// <summary>
        /// Gets or sets the submission date.
        /// </summary>
        /// <value>The submission date.</value>
        public DateTime? SubmissionDate { get; set; }
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int ID { get; set; }
    }
}
