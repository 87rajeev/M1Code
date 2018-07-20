// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-17-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-20-2018
// ***********************************************************************
// <copyright file="ExpressPreorderReserveViewer.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using ASR.Interface;
using System.Linq;
using Sitecore.Diagnostics;
using M1CP.Foundation.ASRReports.Model;

namespace M1CP.Foundation.ASRReports.Viewers
{
    /// <summary>
    /// Viewer class to view the ASR report.
    /// </summary>
    /// <seealso cref="ASR.Interface.BaseViewer" />
    public class ExpressPreorderReserveViewer : BaseViewer
    {
        /// <summary>
        /// Define field names
        /// </summary>
        /// <value>The available columns.</value>
        public override string[] AvailableColumns
        {
            get
            {
                ExpressPreorderReserve logElement = new ExpressPreorderReserve();
                string[] _properties = logElement.GetType().GetProperties().Select(x => x.Name).ToArray();
                return _properties;
            }
        }
        /// <summary>
        /// Display the elements based on the database table.
        /// </summary>
        /// <param name="dElement">The d element.</param>
        public override void Display(DisplayElement dElement)
        {
            DataHelper helper = new DataHelper();
            helper.BindDisplay<ExpressPreorderReserve>(dElement, Columns);
        }

    }
}