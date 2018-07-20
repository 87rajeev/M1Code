// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-15-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-20-2018
// ***********************************************************************
// <copyright file="UnSubscribeDigiCampTran.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace M1CP.Foundation.ASRReports.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Class UnSubscribeDigiCampTran.
    /// </summary>
    public partial class UnSubscribeDigiCampTran
    {
        /// <summary>
        /// Gets or sets the m1 identifier.
        /// </summary>
        /// <value>The m1 identifier.</value>
        public string M1ID { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the contactnumber.
        /// </summary>
        /// <value>The contactnumber.</value>
        public decimal? Contactnumber { get; set; }

        /// <summary>
        /// Gets or sets the TNC.
        /// </summary>
        /// <value>The TNC.</value>
        public string TNC { get; set; }

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
        /// Gets or sets the value5.
        /// </summary>
        /// <value>The value5.</value>
        public string Value5 { get; set; }

        /// <summary>
        /// Gets or sets the un sub date.
        /// </summary>
        /// <value>The un sub date.</value>
        public DateTime? UnSubDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int ID { get; set; }
    }
}
