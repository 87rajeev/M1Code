using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace M1CP.Feature.Forms.Pipeline
{
    public class RegisterWebApiRoutes
    {
        public void Process(PipelineArgs args)
        {
            RouteTable.Routes.MapRoute("Feature", "api/sitecore/Form/Index/{form}", new { controller = "Form", action = "Index" });
        }
    }
}