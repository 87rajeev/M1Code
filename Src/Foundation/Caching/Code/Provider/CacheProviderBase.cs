using System;
using M1CP.Foundation.Caching.Contract;

namespace M1CP.Foundation.Caching.Provider
{

    /// <summary>
    /// Abstract cache base
    /// </summary>
    /// <typeparam name="TCache"></typeparam>
    public abstract class CacheProviderBase<TCache> : ICache
    {
        /// <summary>
        /// Cache duration
        /// </summary>
        public int CacheDuration { get; set; }

        /// <summary>
        /// Cache
        /// </summary>
        public readonly TCache Cache;

        /// <summary>
        /// Cache duration
        /// </summary>
        private const int DefaultCacheDurationMinutes = 30;

        /// <summary>
        /// cache provider base constructor
        /// </summary>
        protected CacheProviderBase()
        {

            CacheDuration = DefaultCacheDurationMinutes;
            this.Cache = InitCache();
        }

        /// <summary>
        /// Initalize the Cache
        /// </summary>
        /// <returns></returns>
        protected abstract TCache InitCache();


        /// <summary>
        /// Get Caches
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Cache key</param>
        /// <returns></returns>
        public abstract T Get<T>(string key);

        /// <summary>
        /// Set the Cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Cache Key</param>
        /// <param name="value">Cache Value</param>
        public virtual void Set<T>(string key, T value)
        {
            Set<T>(GetKey(key), value, CacheDuration);
        }

        /// <summary>
        /// Set the Cache sliding expration
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"> Cache key</param>
        /// <param name="value">Cache value</param>
        public virtual void SetSliding<T>(string key, T value)
        {
            SetSliding<T>(GetKey(key), value, CacheDuration);
        }

        /// <summary>
        /// Abstract method to set cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Cache key</param>
        /// <param name="value">Cache Value</param>
        /// <param name="duration">Cache Duration</param>
        public abstract void Set<T>(string key, T value, int duration);

        /// <summary>
        /// Abstract method to set Cache Sliding expiration
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="duration"></param>
        public abstract void SetSliding<T>(string key, T value, int duration);

        /// <summary>
        /// Set cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Cache Key</param>
        /// <param name="value">Cache Value</param>
        /// <param name="expiration">Cache expiration</param>
        public abstract void Set<T>(string key, T value, DateTimeOffset expiration);

        /// <summary>
        /// Check Cache Exist
        /// </summary>
        /// <param name="key">Cache key</param>
        /// <returns></returns>
        public abstract bool Exists(string key);

        /// <summary>
        /// Remove cache
        /// </summary>
        /// <param name="key">set cache key</param>
        public abstract void Remove(string key);

        /// <summary>
        /// Get or Set Cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Cache key</param>
        /// <param name="valFunction">Cache delegate function</param>
        /// <param name="duration">Cache duration</param>
        /// <returns></returns>
        public virtual T GetOrSet<T>(string key, Func<T> valFunction, int duration) where T : class
        {
            var value = Get<T>(GetKey(key));
            if (null == value)
            {
                value = valFunction();
                lock (this)
                {
                    Set(GetKey(key), value, duration);
                }
            }

            return value;
        }
        static string GetKey(string baseKey)
        {
            return $"{Sitecore.Context.Site.Name}_{Sitecore.Context.Language.Name}_{baseKey}";
        }

    }

}
