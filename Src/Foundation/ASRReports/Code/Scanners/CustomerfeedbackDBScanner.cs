// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-15-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-20-2018
// ***********************************************************************
// <copyright file="CustomerfeedbackDBScanner.cs" company="">
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
    /// Customer feedback DB scanner class
    /// </summary>
    /// <seealso cref="ASR.Interface.BaseScanner" />
    public class CustomerfeedbackDBScanner : ASR.Interface.BaseScanner
    {
        /// <summary>
        /// Scanner to fill the data to the List of Prroperty for binding to Report.
        /// </summary>
        /// <returns>ICollection.</returns>
        public override ICollection Scan()
        {
            DataHelper helper = new DataHelper();
            var items = helper.FillDataSet<CustomerfeedbackDB>(Constants.CustomerfeedbackDB);
            return items;
        }
    }
}