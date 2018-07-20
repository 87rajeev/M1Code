using System;
using System.Runtime.Caching;
using M1CP.Foundation.Caching.Contract;
using M1CP.Foundation.DependencyInjection;


namespace M1CP.Foundation.Caching.Provider
{
   [Service(typeof(ICache))]
    public class InMemoryProvider : CacheProviderBase<MemoryCache>
    {
        /// <summary>
        /// Initialze the cache
        /// </summary>
        /// <returns></returns>
        protected override MemoryCache InitCache()
        {
            return MemoryCache.Default;
        }
    

        /// <summary>
        /// Get Cache by cache key
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
        /// set cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Cache key</param>
        /// <param name="value">Cache value</param>
        /// <param name="duration">Cache duration</param>
        public override void Set<T>(string key, T value, int duration)
        {
            var policy = new CacheItemPolicy { AbsoluteExpiration = DateTime.Now.AddMinutes(duration) };
            Cache.Set(key, value, policy);
        }

        /// <summary>
        /// Set cache sliding expriation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Cache key</param>
        /// <param name="value">Cache value</param>
        /// <param name="duration">Cache duration</param>
        public override void SetSliding<T>(string key, T value, int duration)
        {
            var policy = new CacheItemPolicy { SlidingExpiration = new TimeSpan(0, duration, 0) };
            Cache.Set(key, value, policy);
        }

        /// <summary>
        /// Set cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Cache key</param>
        /// <param name="value">Cache value</param>
        /// <param name="expiration">Cache expiration duration</param>
        public override void Set<T>(string key, T value, DateTimeOffset expiration)
        {
            var policy = new CacheItemPolicy { AbsoluteExpiration = expiration.DateTime };
            Cache.Set(key, value, policy);
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
        /// Remove Cache
        /// </summary>
        /// <param name="key"></param>
        public override void Remove(string key)
        {
            Cache.Remove(key);
        }
    }
}
