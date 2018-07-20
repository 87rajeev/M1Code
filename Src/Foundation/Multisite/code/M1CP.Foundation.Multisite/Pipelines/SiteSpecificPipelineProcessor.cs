using Sitecore.Pipelines.HttpRequest;
using System.Collections.Generic;
using Sitecore;
using System;

namespace M1CP.Foundation.Multisite.Pipelines
{
    /// <summary>
    /// Abstract class to validate the current site is of Corporate portal.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class SiteSpecificPipelineProcessor<T> where T:Sitecore.Pipelines.PipelineArgs
    {
        public List<string> Sites { get; set; }
        /// <summary>
        /// Get the list of Sites available from the Config
        /// </summary>
        protected SiteSpecificPipelineProcessor()
        {
            Sites = new List<string>();
        }
        /// <summary>
        /// Validate the Site
        /// </summary>
        /// <param name="args"></param>
        public void Process(T args)
        {

            if (!Sites.Contains(Sitecore.Context.Site.Name))
                return;
            Run(args);
        }
        protected abstract void Run(T args);
    }
    /// <summary>
    /// Sample code to test the processor. All the process to inherit from the generic process
    /// </summary>
    public class TestProcessor : SiteSpecificPipelineProcessor<HttpRequestArgs>
    {
        protected override void Run(HttpRequestArgs args)
        {
            Sitecore.Diagnostics.Log.Error("Executed", args);
        }
    }
}