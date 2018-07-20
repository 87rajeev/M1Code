
using System;
using System.Collections.Generic;
using System.Diagnostics;
using M1CP.Foundation.Logging;
using M1CP.Foundation.DependencyInjection;
using M1CP.Foundation.Services.Models;
using System.Web;
using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.Caching.Contract;
using M1CP.Foundation.Services.ThrottleHelper;
using Sitecore;

namespace M1CP.Foundation.Services.Helper
{
    /// <summary>
    /// Request base class to handle all requests
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    public abstract class RequestHandlerBase<TRequest, TResponse>
                        where TRequest : Requests.Request
                        where TResponse : Responses.Response<TRequest>
    {
        private readonly ICache _cache;
        private string cacheName = string.Empty;
        private readonly IThrottleProvider _throttle;
        /// <summary>
        /// The throttle requests are handled with the threshold limit for the services.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public virtual TResponse Process(TRequest request)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            if (null == request) throw new ArgumentNullException($"{nameof(request)} is null");
            Logger.Commercelog.Debug($"Time taken {watch.ElapsedMilliseconds }");
            watch.Stop();
            ThrottleProvider _throttleProvider = new ThrottleProvider();
            if (HttpContext.Current.Session.SessionID != null)
            {
                var throttleData = _throttleProvider.GetThrottleData(request.ToString(), HttpContext.Current.Session.SessionID.ToString());
                if (!_throttleProvider.ProcessThrottleRequest(throttleData, HttpContext.Current.Session.SessionID.ToString()))
                {
                    Logger.M1CPLogger.Warn("Service request exceeded maximum limit.");
                    return null;
                }
                var result = Execute(request);
                _throttleProvider.RemoveThrottleRequest(throttleData, HttpContext.Current.Session.SessionID.ToString());
                return result;
            }
            return null;
            
        }
        /// <summary>
        /// Abstract method  to Execute
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        protected abstract TResponse Execute(TRequest request);
        /// <summary>
        /// Abstarct method to handle Request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public abstract TResponse HandleRequest(TRequest request);
        
    }
}