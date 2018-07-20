// ***********************************************************************
// Assembly         : M1CP.Foundation.Logging
// Author           : rshabara
// Created          : 03-24-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-26-2018
// ***********************************************************************
// <copyright file="CustomItemNotFoundResolver.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Pipelines.HttpRequest;

namespace M1CP.Foundation.Logging.Exception
{
    /// <summary>
    /// Class CustomItemNotFoundResolver.
    /// </summary>
    /// <seealso cref="Sitecore.Pipelines.HttpRequest.HttpRequestProcessor" />
    public class CustomItemNotFoundResolver : HttpRequestProcessor
    {
        /// <summary>
        /// Gets or sets the site.
        /// </summary>
        /// <value>The site.</value>
        private string Site { get; set; }
        /// <summary>
        /// Gets or sets the error page identifier.
        /// </summary>
        /// <value>The error page identifier.</value>
        private string ErrorPageId { get; set; }

        /// <summary>
        /// Processes the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public override void Process(HttpRequestArgs args)
        {
            try
            {
                Assert.ArgumentNotNull(args, "args");
                // Do nothing if the item is actually found
                if (Sitecore.Context.Item != null || Sitecore.Context.Database == null)
                    return;
                var contextSiteName = Context.GetSiteName();
                //Sites = new List<string>();
                if (string.IsNullOrWhiteSpace(contextSiteName) || string.IsNullOrWhiteSpace(Site) || (!string.IsNullOrWhiteSpace(Site) && string.IsNullOrWhiteSpace(contextSiteName) && Site.ToLower() != contextSiteName.ToLower()))
                    return;
                // all the icons and media library items
                // for the sitecore client need to be ignored
                if (args.Url.FilePath.StartsWith("/ -/"))
                    return;
                // Get the 404 not found item in Sitecore.
                // You can add more complex code to get the 404 item
                // from multisite solutions. In a production
                // environment you would probably get the item from
                // your website configuration.
                if (ErrorPageId != null)
                {
                    Item notFoundPage = Sitecore.Context.Database.GetItem(ErrorPageId);
                    if (notFoundPage == null)
                        return;
                    Sitecore.Context.Item = notFoundPage;
                }
            }
            catch (System.Exception ex)
            {
               
                Logger.Log404.Error(ex.Message);
            
            }
        }
    }
}