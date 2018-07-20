using M1CP.Foundation.Base.Entities;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Base.Infrastructure.Pipelines.SetCallContetxt
{
    public class CallContextProcessorArgument : Sitecore.Pipelines.PipelineArgs
    {
        public CallContext CallContext { get; set; }
        public Item RequestItem{ get; set; }
        public HttpRequest Request { get; set; }
    }
}