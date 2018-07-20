// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-15-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-16-2018
// ***********************************************************************
// <copyright file="CustomerfeedbackDB.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace M1CP.Foundation.ASRReports.Model
{

    /// <summary>
    /// Class CustomerfeedbackDB.
    /// </summary>
    public partial class CustomerfeedbackDB
    {

        /// <summary>
        /// Gets or sets the customerid.
        /// </summary>
        /// <value>The customerid.</value>
        public Guid customerid { get; set; }


        /// <summary>
        /// Gets or sets the main category.
        /// </summary>
        /// <value>The main category.</value>
        public string MainCategory { get; set; }

        /// <summary>
        /// Gets or sets the sub category.
        /// </summary>
        /// <value>The sub category.</value>
        public string SubCategory { get; set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>The comments.</value>
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets the salutation.
        /// </summary>
        /// <value>The salutation.</value>
        public string Salutation { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the type of the identifier.
        /// </summary>
        /// <value>The type of the identifier.</value>
        public string IDType { get; set; }
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the contact no.
        /// </summary>
        /// <value>The contact no.</value>
        public string ContactNo { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the m1 customer.
        /// </summary>
        /// <value>The m1 customer.</value>
        public string M1Customer { get; set; }

        /// <summary>
        /// Gets or sets the user i dor existing m1 number.
        /// </summary>
        /// <value>The user i dor existing m1 number.</value>
        public string UserIDorExistingM1Number { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        /// <value>The create date.</value>
        public DateTime? CreateDate { get; set; }
    }
}
