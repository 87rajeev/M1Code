// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-15-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-22-2018
// ***********************************************************************
// <copyright file="MegadealsROI.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace M1CP.Foundation.ASRReports.Model
{
    /// <summary>
    /// Class MegadealsROI.
    /// </summary>
    public partial class MegadealsROI
    {
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>The customer identifier.</value>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        /// <value>The create date.</value>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the name of the campaign.
        /// </summary>
        /// <value>The name of the campaign.</value>
        public string CampaignName { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        /// <value>The name of the customer.</value>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the customer detail1.
        /// </summary>
        /// <value>The customer detail1.</value>
        public string CustomerDetail1 { get; set; }

        /// <summary>
        /// Gets or sets the customer detail2.
        /// </summary>
        /// <value>The customer detail2.</value>
        public string CustomerDetail2 { get; set; }
        
    }
}
