using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
namespace M1CP.Foundation.Base.Pipeline
{
    public class BundleConfig
    {
        public virtual void Process(PipelineArgs args)
        {
            //BundleConfig.RegisterBundles(BundleTable.Bundles);           
            //EnableBundleOptimizations();
        }
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundle/scripts").Include("~/content/js/*.js"));
            bundles.Add(new StyleBundle("~/bundle/styles").Include("~/content/css/*.css"));
        }

        /// <summary>
        /// Enable bundling when release mode
        /// </summary>
        private void EnableBundleOptimizations()
        {
            #if DEBUG
                        BundleTable.EnableOptimizations = false; // disable bundling
            #else
                        BundleTable.EnableOptimizations = true;
            #endif
        }
    }
}