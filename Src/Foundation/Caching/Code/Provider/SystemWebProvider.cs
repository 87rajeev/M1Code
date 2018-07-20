using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using M1CP.Foundation.Caching.Contract;
using M1CP.Foundation.DependencyInjection;

namespace M1CP.Foundation.Caching.Provider
{
   
    public class SystemWebProvider : CacheProviderBase<System.Web.Caching.Cache>
    {
        /// <summary>
        /// Initialize the cache
        /// </summary>
        /// <returns></returns>
        protected override System.Web.Caching.Cache InitCache()
        {
            return HttpRuntime.Cache;
        }

        
        /// <summary>
        /// Get the cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Cache key</param>
        /// <returns></returns>
        public override T Get<T>(string key)
        {
            try
            {
                if (!Exists(key))
                {
                    return default(T);
                }

                return (T)Cache[key];
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// Set Cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Cache key</param>
        /// <param name="value">Cache value</param>
        /// <param name="duration">Cache duration</param>
        public override void Set<T>(string key, T value, int duration)
        {
            Cache.Insert(
                 key,
                value,
                null,
                System.Web.Caching.Cache.NoAbsoluteExpiration,
                new TimeSpan(0, duration, 0));
        }

        /// <summary>
        /// Set Cache sliding expiration
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Cache key</param>
        /// <param name="value">Cache value</param>
        /// <param name="duration">Cache duration</param>
        public override void SetSliding<T>(string key, T value, int duration)
        {
            Cache.Insert(
                 key,
                value,
                null,
                DateTime.Now.AddMinutes(duration),
                System.Web.Caching.Cache.NoSlidingExpiration);
        }

        /// <summary>
        /// Set Cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Cache key</param>
        /// <param name="value">Cache value</param>
        /// <param name="expiration">Cache duration</param>
        public override void Set<T>(string key, T value, DateTimeOffset expiration)
        {
            Cache.Insert(
                 key,
                value,
                null,
                expiration.DateTime,
                System.Web.Caching.Cache.NoSlidingExpiration);
        }

        /// <summary>
        /// Check cache exist
        /// </summary>
        /// <param name="key">Cache key</param>
        /// <returns></returns>
        public override bool Exists(string key)
        {
            return Cache[key] != null;
        }

        /// <summary>
        /// Remove the Cache
        /// </summary>
        /// <param name="key"></param>
        public override void Remove(string key)
        {
            Cache.Remove(key);
        }
    }
}
