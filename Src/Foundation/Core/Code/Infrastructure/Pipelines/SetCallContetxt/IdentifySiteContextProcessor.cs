using Sitecore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Base.Infrastructure.Pipelines.SetCallContetxt
{
    public class IdentifySiteContextProcessor
    {
        public void Process(CallContextProcessorArgument args)
        {
            Assert.ArgumentNotNull(args?.CallContext?.Site,"Callcontext Site");
        }
    }
}