using Sitecore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Base.Infrastructure.Pipelines.SetCallContetxt
{
    public class IdentifyUserContextProcessor
    {
        public void Process(CallContextProcessorArgument args)
        {
            /// Read user details from Session/Cookie.
            /// Set RequestContext user and args.User
            Assert.ArgumentNotNull(args?.CallContext?.User, "Callcontext User");
        }
    }
}