// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-15-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-15-2018
// ***********************************************************************
// <copyright file="M1SearchTerm.cs" company="">
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
    /// Class M1SearchTerm.
    /// </summary>
    public partial class M1SearchTerm
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the search term.
        /// </summary>
        /// <value>The search term.</value>
        public string SearchTerm { get; set; }

        /// <summary>
        /// Gets or sets the user agent.
        /// </summary>
        /// <value>The user agent.</value>
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or sets the channel.
        /// </summary>
        /// <value>The channel.</value>
        public string Channel { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        /// <value>The create date.</value>
        public DateTime? CreateDate { get; set; }

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
    }
}
