// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-15-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-20-2018
// ***********************************************************************
// <copyright file="M1GolfRSVPViewer.cs" company="">
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
    public class M1GolfRSVPViewer : BaseViewer
    {
        /// <summary>
        /// Fill the Column names to display in viewer.
        /// </summary>
        /// <value>The available columns.</value>
        public override string[] AvailableColumns
        {
            get
            {
                M1GolfRSVP logElement = new M1GolfRSVP();
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
            helper.BindDisplay<M1GolfRSVP>(dElement, Columns);
        }

    }
}