// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-20-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-20-2018
// ***********************************************************************
// <copyright file="M1ShopWorkshop.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace M1CP.Foundation.ASRReports.Model
{

    /// <summary>
    /// Class M1ShopWorkshop.
    /// </summary>
    public partial class M1ShopWorkshop
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
        /// Gets or sets the nric.
        /// </summary>
        /// <value>The nric.</value>
        public string NRIC { get; set; }

        /// <summary>
        /// Gets or sets the mobile number.
        /// </summary>
        /// <value>The mobile number.</value>
        public string MobileNumber { get; set; }

        /// <summary>
        /// Gets or sets the contact number.
        /// </summary>
        /// <value>The contact number.</value>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the workshop.
        /// </summary>
        /// <value>The name of the workshop.</value>
        public string WorkshopName { get; set; }
        /// <summary>
        /// Gets or sets the workshop location.
        /// </summary>
        /// <value>The workshop location.</value>
        public string WorkshopLocation { get; set; }

        /// <summary>
        /// Gets or sets the workshop date.
        /// </summary>
        /// <value>The workshop date.</value>
        public string WorkshopDate { get; set; }

        /// <summary>
        /// Gets or sets the workshop time.
        /// </summary>
        /// <value>The workshop time.</value>
        public string WorkshopTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [bring friend].
        /// </summary>
        /// <value><c>true</c> if [bring friend]; otherwise, <c>false</c>.</value>
        public bool BringFriend { get; set; }

        /// <summary>
        /// Gets or sets the numberof attandance.
        /// </summary>
        /// <value>The numberof attandance.</value>
        public int NumberofAttandance { get; set; }
        /// <summary>
        /// Gets or sets the alt email.
        /// </summary>
        /// <value>The alt email.</value>
        public string AltEmail { get; set; }
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
