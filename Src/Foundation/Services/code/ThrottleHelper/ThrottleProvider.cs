using M1CP.Foundation.Caching.Provider;
using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.Services.Models;
using Sitecore;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Services.ThrottleHelper
{
    /// <summary>
    /// Threshold provider to assign threshold limits and remove threshold.
    /// </summary>
    internal  class ThrottleProvider : RepositoryBase, IThrottleProvider
    {
        /// <summary>
        /// To set the Threshold
        /// </summary>
        /// <param name="throttleData"></param>
        /// <param name="sessionId"></param>
        /// <returns></returns>
         private static bool SetData(ThrottleUserAccess throttleData,string sessionId)
        {
            bool addThrottle = false;
            var cache = new InMemoryProvider();
            string cacheKey = Constants.Constants.CachePrefix + throttleData.ThrottleGroup;
            ThrottleCache throttleCache = (ThrottleCache)cache.Cache[cacheKey];
            if (throttleCache == null)
            {
                 throttleCache = new ThrottleCache();
                throttleCache.ApiName = throttleData.ThrottleGroup;
                throttleCache.ThrottleSessionIds = new List<string>();
            }
            
            cache.GetOrSet(cacheKey, () => throttleCache, Constants.Constants.Duration);

            if (RefeshSessions(throttleData) && cache.Exists(cacheKey))
            {
                throttleCache=(ThrottleCache)cache.Cache[cacheKey];
                if(throttleCache.ThrottleSessionIds.Count >= throttleData.Capacity)
                {
                    return false;
                }
                if (throttleCache.ThrottleSessionIds.Count > 0)
                {
                    var throttleSession = throttleCache.ThrottleSessionIds.Where(x => x == HttpContext.Current.Session.SessionID.ToString());
                    if (throttleSession.Count() == 0)
                    {       
                        addThrottle = true;
                    }
                }
                else
                    addThrottle = true;
            }
            else
            {
                addThrottle = true;
            }
            if (addThrottle)
            {
                throttleCache.ThrottleSessionIds.Add(sessionId);
                var cachedData = cache.GetOrSet(cacheKey, () =>
                throttleCache, Constants.Constants.Duration);
            }

            return true;
        }
        /// <summary>
        /// To remove Threshold
        /// </summary>
        /// <param name="throttleData"></param>
        /// <param name="sessionId"></param>
        /// <returns></returns>
        private static bool RemoveData(ThrottleUserAccess throttleData, string sessionId)
        {
            var cache = new InMemoryProvider();
            string cacheKey = Constants.Constants.CachePrefix + throttleData.ThrottleGroup;
            ThrottleCache throttleCache = (ThrottleCache)cache.Cache[cacheKey];
           
            if (throttleCache == null)
            {
                throttleCache = new ThrottleCache();
                throttleCache.ApiName = throttleData.ThrottleGroup;
                throttleCache.ThrottleSessionIds = new List<string>();
            }
            if (RefeshSessions(throttleData) && cache.Exists(cacheKey))
            {
                if (throttleCache.ThrottleSessionIds.Count > 0)
                {
                    var throttleSession = throttleCache.ThrottleSessionIds.Where(x => x == sessionId);
                    if (throttleSession.Count() > 0)
                    {
                        throttleCache.ThrottleSessionIds.Remove(sessionId);
                        cache.GetOrSet(cacheKey, () => throttleCache, Constants.Constants.Duration);
                    }
                }
            }

            return true;
        }
        /// <summary>
        /// Refresh Session
        /// </summary>
        /// <param name="throttleData"></param>
        /// <returns></returns>
        private static bool RefeshSessions(ThrottleUserAccess throttleData)
        {
            return true;
        }
        /// <summary>
        /// Process Threshold
        /// </summary>
        /// <param name="throttleData"></param>
        /// <param name="addThrottle"></param>
        /// <param name="sessionId"></param>
        /// <returns></returns>
        private static bool ProcessThrottle(ThrottleUserAccess throttleData, bool addThrottle,string sessionId)
        {
            if (addThrottle)
            {
                return SetData(throttleData, sessionId);
            }
            else
            {
                return RemoveData(throttleData, sessionId);
            }

        }
        /// <summary>
        /// Get Throttle values
        /// </summary>
        /// <param name="apiName"></param>
        /// <param name="sessionId"></param>
        /// <returns></returns>
        public ThrottleUserAccess GetThrottleValues(string apiName,string sessionId)
        {
            ThrottleUserAccess throttleUserAccess = new ThrottleUserAccess();
            bool throttleServiceFound = false;
            if (ScContext.Database != null)
            {
                var throttleSessionCollection = ScContext.GetItem<ThrottleSessionCollection>(Templates.Throttle.Fields.Select_ThrottleList_FieldId);
                if (throttleSessionCollection != null && throttleSessionCollection.ThrottleList != null)
                {
                    foreach (var throttle in throttleSessionCollection.ThrottleList)
                    {
                        
                        if (throttle.ServiceName.ToLower() == apiName.ToLower())
                        {
                            throttleUserAccess = throttle;
                            throttleServiceFound = true;
                        }
                    }
                }
                if (!throttleServiceFound && Context.Item!=null)
                {
                    var throttlePage = ScContext.GetItem<PageThrottle>(Context.Item.ID.ToString());
                    if (throttlePage != null)
                    {
                        if (throttlePage.ThrottleEnabled && throttlePage.ThrottleCapacity != string.Empty)
                        {
                            throttleUserAccess.ServiceName = apiName.ToLower();
                            throttleUserAccess.ThrottleGroup = apiName.ToLower();
                            throttleUserAccess.Capacity = int.Parse(throttlePage.ThrottleCapacity);
                            throttleUserAccess.Throttling = true;
                        }
                    }
                }
            }
            else
            {
                throttleUserAccess.ServiceName = apiName;
                RemoveThrottleRequest(throttleUserAccess, sessionId);

            }
            return throttleUserAccess;
        }
        /// <summary>
        /// Process Threshold requests
        /// </summary>
        /// <param name="throttleData"></param>
        /// <param name="sessionId"></param>
        /// <returns></returns>
        public bool ProcessThrottleRequest(ThrottleUserAccess throttleData,string sessionId)
        {
            bool throttled = ProcessThrottle(throttleData, true, sessionId);
            return throttled;
        }
        /// <summary>
        /// Remove throttle requests
        /// </summary>
        /// <param name="throttleData"></param>
        /// <param name="sessionId"></param>
        /// <returns></returns>
        public bool RemoveThrottleRequest(ThrottleUserAccess throttleData, string sessionId)
        {
            bool throttled = ProcessThrottle(throttleData, false, sessionId);
            return throttled;
        }
        /// <summary>
        /// Get the throttle Data
        /// </summary>
        /// <param name="url"></param>
        /// <param name="sessionId"></param>
        /// <returns></returns>
        public ThrottleUserAccess GetThrottleData(string url,string sessionId)
        {
            ThrottleProvider throttleHandler = new ThrottleProvider();
            ThrottleUserAccess access = throttleHandler.GetThrottleValues(url, sessionId);
            return access;
        }
    }
}