// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-20-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-20-2018
// ***********************************************************************
// <copyright file="ContestSubmissionViewer.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using ASR.Interface;
using Sitecore.Diagnostics;
using M1CP.Foundation.ASRReports.Model;
using System.Linq;
namespace M1CP.Foundation.ASRReports.Viewers
{
    /// <summary>
    /// Viewer class to view the ASR report.
    /// </summary>
    /// <seealso cref="ASR.Interface.BaseViewer" />
    public class ContestSubmissionViewer : BaseViewer
    {
        /// <summary>
        /// Fill the Column names to display in viewer.
        /// </summary>
        /// <value>The available columns.</value>
        public override string[] AvailableColumns
        {
            get
            {
                ContestSubmission logElement = new ContestSubmission();
                string[] _properties = logElement.GetType().GetProperties().Select(x => x.Name).ToArray();
                return _properties;
            }
        }
        /// <summary>
        /// Populate the Display values in ASR.
        /// </summary>
        /// <param name="dElement">The d element.</param>
        public override void Display(DisplayElement dElement)
        {
            DataHelper helper = new DataHelper();
            helper.BindDisplay<ContestSubmission>(dElement, Columns);
        }
    }
}