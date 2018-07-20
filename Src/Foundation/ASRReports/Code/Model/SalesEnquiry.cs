// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-15-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-22-2018
// ***********************************************************************
// <copyright file="SalesEnquiry.cs" company="">
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
    /// Class SalesEnquiry.
    /// </summary>
    public partial class SalesEnquiry
    {
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>The customer identifier.</value>
        public int CustomerID { get; set; }

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
        /// Gets or sets a value indicating whether [m1 business customer].
        /// </summary>
        /// <value><c>true</c> if [m1 business customer]; otherwise, <c>false</c>.</value>
        public bool M1BusinessCustomer { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        /// <value>The create date.</value>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the contact number.
        /// </summary>
        /// <value>The contact number.</value>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of the product.
        /// </summary>
        /// <value>The type of the product.</value>
        public string ProductType { get; set; }

        /// <summary>
        /// Gets or sets the contract expiry.
        /// </summary>
        /// <value>The contract expiry.</value>
        public DateTime? ContractExpiry { get; set; }
        /// <summary>
        /// Gets or sets the expecting re contract soon.
        /// </summary>
        /// <value>The expecting re contract soon.</value>
        public string ExpectingReContractSoon { get; set; }
        /// <summary>
        /// Gets or sets the promo code.
        /// </summary>
        /// <value>The promo code.</value>
        public string PromoCode { get; set; }

        /// <summary>
        /// Gets or sets the how can we assist.
        /// </summary>
        /// <value>The how can we assist.</value>
        public string HowCanWeAssist { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [subscribe to mailing].
        /// </summary>
        /// <value><c>true</c> if [subscribe to mailing]; otherwise, <c>false</c>.</value>
        public bool SubscribeToMailing { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }

    }
}
