// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-15-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-22-2018
// ***********************************************************************
// <copyright file="ExpressPreorderReserve.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace M1CP.Foundation.ASRReports.Model
{

    /// <summary>
    /// Class ExpressPreorderReserve.
    /// </summary>
    public partial class ExpressPreorderReserve
    {
        /// <summary>
        /// Gets or sets the transaction identifier.
        /// </summary>
        /// <value>The transaction identifier.</value>
        public Guid? Transaction_ID { get; set; }

        /// <summary>
        /// Gets or sets the m1 identifier.
        /// </summary>
        /// <value>The m1 identifier.</value>
        public string M1ID { get; set; }

        /// <summary>
        /// Gets or sets the i dnumber.
        /// </summary>
        /// <value>The i dnumber.</value>
        public string IDnumber { get; set; }

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
        /// Gets or sets the pre order URL.
        /// </summary>
        /// <value>The pre order URL.</value>
        public string PreOrderUrl { get; set; }

        /// <summary>
        /// Gets or sets the re contract.
        /// </summary>
        /// <value>The re contract.</value>
        public string ReContract { get; set; }

        /// <summary>
        /// Gets or sets the re contract SVC no.
        /// </summary>
        /// <value>The re contract SVC no.</value>
        public decimal? ReContractSvcNo { get; set; }

        /// <summary>
        /// Gets or sets the change plan.
        /// </summary>
        /// <value>The change plan.</value>
        public string ChangePlan { get; set; }

        /// <summary>
        /// Gets or sets the prospect.
        /// </summary>
        /// <value>The prospect.</value>
        public string Prospect { get; set; }

        /// <summary>
        /// Gets or sets the preferred model1.
        /// </summary>
        /// <value>The preferred model1.</value>
        public string PreferredModel1 { get; set; }

        /// <summary>
        /// Gets or sets the preferred model2.
        /// </summary>
        /// <value>The preferred model2.</value>
        public string PreferredModel2 { get; set; }

        /// <summary>
        /// Gets or sets the preferred model3.
        /// </summary>
        /// <value>The preferred model3.</value>
        public string PreferredModel3 { get; set; }

        /// <summary>
        /// Gets or sets the eligible pre order.
        /// </summary>
        /// <value>The eligible pre order.</value>
        public string EligiblePreOrder { get; set; }

        /// <summary>
        /// Gets or sets the roi date.
        /// </summary>
        /// <value>The roi date.</value>
        public DateTime? ROIDate { get; set; }

        /// <summary>
        /// Gets or sets the eligible check date.
        /// </summary>
        /// <value>The eligible check date.</value>
        public DateTime? EligibleCheckDate { get; set; }

        /// <summary>
        /// Gets or sets the order XML transaction identifier.
        /// </summary>
        /// <value>The order XML transaction identifier.</value>
        public string OrderXMLTransactionID { get; set; }

        /// <summary>
        /// Gets or sets the collection location.
        /// </summary>
        /// <value>The collection location.</value>
        public string CollectionLocation { get; set; }

        /// <summary>
        /// Gets or sets the rule engine error code.
        /// </summary>
        /// <value>The rule engine error code.</value>
        public string RuleEngineErrCode { get; set; }

        /// <summary>
        /// Gets or sets the rule engine error MSG.
        /// </summary>
        /// <value>The rule engine error MSG.</value>
        public string RuleEngineErrMsg { get; set; }

        /// <summary>
        /// Gets or sets the device.
        /// </summary>
        /// <value>The device.</value>
        public string Device { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        /// <value>The create date.</value>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the useragent.
        /// </summary>
        /// <value>The useragent.</value>
        public string useragent { get; set; }
        /// <summary>
        /// Gets or sets the non payment SMS.
        /// </summary>
        /// <value>The non payment SMS.</value>
        public string NonPaymentSMS { get; set; }
        /// <summary>
        /// Gets or sets the short preorder URL.
        /// </summary>
        /// <value>The short preorder URL.</value>
        public string ShortPreorderUrl { get; set; }
    }
}
