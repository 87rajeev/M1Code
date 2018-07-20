using M1CP.Foundation.Caching.Provider;
using M1CP.Foundation.Logging;
using M1CP.Foundation.Services.Models;
using Sitecore.Pipelines.HttpRequest;
using Sitecore.Pipelines.SessionEnd;
using Sitecore.Security.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;

namespace M1CP.Foundation.Services.ThrottleHelper
{
    public class SessionEndProcessor
    {
        public  void Process(SessionEndArgs args)
        {
            try
            {
                string sessionId = args.Context.Session.SessionID.ToString();
                RemoveFromAllCache(sessionId);
               
            }
            catch (Exception ex)
            {
                Logger.M1CPLogger.Error(ex.Message, ex);
            }
        }
        private void RemoveFromAllCache(string sessionId)
        {
            var cache = new InMemoryProvider();
            //Constants.Constants.CachePrefix;
            
            ThrottleCache throttleCache = new ThrottleCache();
            foreach (var item in MemoryCache.Default)
            {
                if(item.Key.Contains(Constants.Constants.CachePrefix))
                {
                    throttleCache = (ThrottleCache)cache.Cache[item.Key];
                    throttleCache.ThrottleSessionIds.Remove(sessionId);
                }
                //add the item.keys to list
            }

            // throttleCache = (ThrottleCache)cache.Cache[cacheKey]; 
        }
    }
}