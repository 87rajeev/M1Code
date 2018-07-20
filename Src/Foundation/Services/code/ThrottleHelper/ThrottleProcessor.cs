using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.ItemWebApi.Pipelines.Request;
using Sitecore.Pipelines.HttpRequest;
using M1CP.Foundation.Services.Models;
using M1CP.Foundation.DependencyInjection;
using M1CP.Foundation.Logging;
using System.Web.Services.Description;
using Sitecore.DependencyInjection;
using Sitecore.Diagnostics;
using System.Diagnostics;
using static Sitecore.Configuration.Settings;

namespace M1CP.Foundation.Services.ThrottleHelper
{
    //[Service(typeof(IThrottleProvider))]
    public class ThrottleProcessor : HttpRequestProcessor
    {
        private readonly IThrottleProvider _throttleProvider;
        public ThrottleProcessor(IThrottleProvider throttle)
        {
            _throttleProvider = throttle;
        }
        public ThrottleProcessor() : this(new ThrottleProvider())
        {
        }
        /// <summary>
        /// To process the throttle request through the Httprequest processor
        /// </summary>
        /// <param name="arguments"></param>
        public override void Process(HttpRequestArgs arguments)
        {
            if (arguments.Context.Session != null)
            {
                var throttleData = _throttleProvider.GetThrottleData(arguments.RequestUrl.ToString(), arguments.Context.Session.SessionID.ToString());
                if (throttleData != null && throttleData.ThrottleGroup != null)
                {
                    if (!_throttleProvider.ProcessThrottleRequest(throttleData, arguments.Context.Session.SessionID.ToString()))
                    {
                        
                        Logger.M1CPLogger.Warn("Service request exceeded maximum limit.");
                    }
                }
            }
        }
    }
}