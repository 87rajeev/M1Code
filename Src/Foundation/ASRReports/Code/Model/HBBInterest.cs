// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-15-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-15-2018
// ***********************************************************************
// <copyright file="HBBInterest.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace M1CP.Foundation.ASRReports.Model
{

    /// <summary>
    /// Class HBBInterest.
    /// </summary>
    public partial class HBBInterest
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
        /// Gets or sets the create date.
        /// </summary>
        /// <value>The create date.</value>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>The postal code.</value>
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        /// <value>The name of the customer.</value>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the block number.
        /// </summary>
        /// <value>The block number.</value>
        public string BlockNum { get; set; }

        /// <summary>
        /// Gets or sets the floor number.
        /// </summary>
        /// <value>The floor number.</value>
        public string FloorNum { get; set; }

        /// <summary>
        /// Gets or sets the unit number.
        /// </summary>
        /// <value>The unit number.</value>
        public string UnitNum { get; set; }

        /// <summary>
        /// Gets or sets the nric.
        /// </summary>
        /// <value>The nric.</value>
        public string NRIC { get; set; }

        /// <summary>
        /// Gets or sets the name of the street.
        /// </summary>
        /// <value>The name of the street.</value>
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or sets the name of the apartment.
        /// </summary>
        /// <value>The name of the apartment.</value>
        public string ApartmentName { get; set; }

        /// <summary>
        /// Gets or sets the mobile number.
        /// </summary>
        /// <value>The mobile number.</value>
        public string MobileNumber { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the home reno completion.
        /// </summary>
        /// <value>The home reno completion.</value>
        public string HomeRenoCompletion { get; set; }

        /// <summary>
        /// Gets or sets the service status.
        /// </summary>
        /// <value>The service status.</value>
        public string ServiceStatus { get; set; }

        /// <summary>
        /// Gets or sets the contact number.
        /// </summary>
        /// <value>The contact number.</value>
        public string ContactNumber { get; set; }

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
