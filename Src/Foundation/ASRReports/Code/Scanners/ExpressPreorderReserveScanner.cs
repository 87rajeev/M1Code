// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-17-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-22-2018
// ***********************************************************************
// <copyright file="ExpressPreorderReserveScanner.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using M1CP.Foundation.ASRReports.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
namespace M1CP.Foundation.ASRReports.Scanners
{
    /// <summary>
    /// ExpressPreorderReserveScanner scanner class
    /// </summary>
    /// <seealso cref="ASR.Interface.BaseScanner" />
    public class ExpressPreorderReserveScanner : ASR.Interface.BaseScanner
    {
        /// <summary>
        /// Scanner to fill the data to the List of Prroperty for binding to Report.
        /// </summary>
        /// <returns>ICollection.</returns>
        public override ICollection Scan()
        {
            DataHelper helper = new DataHelper();
            var items = helper.FillDataSet<ExpressPreorderReserve>(Constants.ExpressPreorderReserve);
            //Logic to update the SMS and Short URL
            foreach (var item in items)
            {
                item.ShortPreorderUrl = "Short URL";
                item.NonPaymentSMS = "Non payment SMS";
            }
            return items;
        }
    }
}