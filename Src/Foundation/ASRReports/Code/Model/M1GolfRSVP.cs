// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-15-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-15-2018
// ***********************************************************************
// <copyright file="M1GolfRSVP.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace M1CP.Foundation.ASRReports.Model
{

    /// <summary>
    /// Class M1GolfRSVP.
    /// </summary>
    public partial class M1GolfRSVP
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
        /// Gets or sets the customer designation.
        /// </summary>
        /// <value>The customer designation.</value>
        public string CustomerDesignation { get; set; }

        /// <summary>
        /// Gets or sets the current handicap.
        /// </summary>
        /// <value>The current handicap.</value>
        public string CurrentHandicap { get; set; }

        /// <summary>
        /// Gets or sets the mobile number.
        /// </summary>
        /// <value>The mobile number.</value>
        public string MobileNumber { get; set; }

        /// <summary>
        /// Gets or sets the customer email.
        /// </summary>
        /// <value>The customer email.</value>
        public string CustomerEmail { get; set; }

        /// <summary>
        /// Gets or sets the home club.
        /// </summary>
        /// <value>The home club.</value>
        public string HomeClub { get; set; }

        /// <summary>
        /// Gets or sets the club member no.
        /// </summary>
        /// <value>The club member no.</value>
        public string ClubMemberNo { get; set; }

        /// <summary>
        /// Gets or sets the attendance.
        /// </summary>
        /// <value>The attendance.</value>
        public string Attendance { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        /// <value>The create date.</value>
        public DateTime? CreateDate { get; set; }
    }
}
