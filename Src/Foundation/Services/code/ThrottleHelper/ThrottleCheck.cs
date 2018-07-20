using Glass.Mapper.Sc;
using M1CP.Foundation.Caching.Contract;
using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.Services.Models;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Sitecore.Configuration.Settings;

namespace M1CP.Foundation.Services.Helper
{
    public  class ThrottleCheck : RepositoryBase
    {
        private  readonly ICache _cache;
        private string cacheName = string.Empty;

        private int ThrottleCount(string apiName)
        {
            int throttleCount = 0;
            var throttleSessionCollection = ScContext.GetCurrentItem<ThrottleSessionCollection>();
            //var throttleData = ScContext.GetCurrentItem<ThrottleUserAccess>();

            foreach (var throttle in throttleSessionCollection.ThrottleList)
            {
                if (throttle.ServiceName == apiName)
                {
                    throttleCount = throttle.Capacity;
                    cacheName = throttle.ThrottleGroup;
                }
            }
            //if (throttleData.Throttling)
            //{
            //    throttleCount = throttleData.Capacity;
            //}

            return throttleCount;
        }
        
        public bool ThrottleAddtoCacheCheckExceeded(string apiName)
        {
            ThrottleCache throttleCache = new ThrottleCache();
            string cacheKey = Constants.Constants.CachePrefix + cacheName;
            bool addThrottle;
            if (_cache.Exists(cacheKey) && HttpContext.Current.Cache[cacheKey] != null)
            {
                throttleCache = (ThrottleCache)HttpContext.Current.Cache[cacheKey];
                if (ThrottleCount(apiName) <= throttleCache.ThrottleSessionIds.Count)
                    return true;

                if (throttleCache.ThrottleSessionIds.Count > 0 && throttleCache.ApiName == apiName)
                {
                    var throttleSession = throttleCache.ThrottleSessionIds.Where(x => x == HttpContext.Current.Session.SessionID.ToString());
                    if (throttleSession.Count() == 0)
                        throttleCache.ThrottleSessionIds.Add(HttpContext.Current.Session.SessionID.ToString());

                }

                addThrottle = true;
            }
            else
            {
                addThrottle = true;

            }
            if (addThrottle)
            {
                throttleCache.ApiName = apiName;
                throttleCache.ThrottleSessionIds.Add(HttpContext.Current.Session.SessionID.ToString());
                var cachedData = _cache.GetOrSet(cacheKey, () =>
                throttleCache, Constants.Constants.Duration);
            }

            return false;
        }
    }
}