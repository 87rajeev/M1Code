// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-15-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-15-2018
// ***********************************************************************
// <copyright file="EnterpriseRSVP.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace M1CP.Foundation.ASRReports.Model
{

    /// <summary>
    /// Class EnterpriseRSVP.
    /// </summary>
    public partial class EnterpriseRSVP
    {
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>The customer identifier.</value>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the name of the campaign.
        /// </summary>
        /// <value>The name of the campaign.</value>
        public string CampaignName { get; set; }

        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>The name of the company.</value>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        /// <value>The name of the customer.</value>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the mobile number.
        /// </summary>
        /// <value>The mobile number.</value>
        public string MobileNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="EnterpriseRSVP"/> is dietary.
        /// </summary>
        /// <value><c>null</c> if [dietary] contains no value, <c>true</c> if [dietary]; otherwise, <c>false</c>.</value>
        public bool? Dietary { get; set; }

        /// <summary>
        /// Gets or sets the dietary preference.
        /// </summary>
        /// <value>The dietary preference.</value>
        public string DietaryPreference { get; set; }

        /// <summary>
        /// Gets or sets the preferred date.
        /// </summary>
        /// <value>The preferred date.</value>
        public string PreferredDate { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        /// <value>The create date.</value>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the company BRN.
        /// </summary>
        /// <value>The company BRN.</value>
        public string CompanyBRN { get; set; }

        /// <summary>
        /// Gets or sets the customer email.
        /// </summary>
        /// <value>The customer email.</value>
        public string CustomerEmail { get; set; }

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

        /// <summary>
        /// Gets or sets the contact number.
        /// </summary>
        /// <value>The contact number.</value>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Gets or sets the designation.
        /// </summary>
        /// <value>The designation.</value>
        public string Designation { get; set; }

        /// <summary>
        /// Gets or sets the customer detail3.
        /// </summary>
        /// <value>The customer detail3.</value>
        public string CustomerDetail3 { get; set; }

        /// <summary>
        /// Gets or sets the customer detail4.
        /// </summary>
        /// <value>The customer detail4.</value>
        public string CustomerDetail4 { get; set; }
    }
}
