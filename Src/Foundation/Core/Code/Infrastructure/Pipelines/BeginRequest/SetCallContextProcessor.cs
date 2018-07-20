using M1CP.Foundation.Base.Entities;
using M1CP.Foundation.Base.Infrastructure.Pipelines.SetCallContetxt;
using Sitecore.Pipelines;
using Sitecore.Pipelines.HttpRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Base.Infrastructure.Pipelines.BeginRequest
{
    public class SetCallContextProcessor : HttpRequestProcessor
    {
        /// <summary>
        /// Process Current Request to Set Call Context
        /// </summary>
        /// <param name="args"></param>
        public override void Process(HttpRequestArgs args)
        {
            CallContextProcessorArgument callContextProcessorArgument = new CallContextProcessorArgument
            {
                CallContext = new CallContext(),
                RequestItem = args?.ProcessorItem?.InnerItem
            };

            CorePipeline.Run(Constants.CallContextProcessor, callContextProcessorArgument);
            CallContext.SetCurrentContext(callContextProcessorArgument.CallContext);
        }


    }
}