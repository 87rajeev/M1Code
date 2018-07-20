using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M1CP.Foundation.Caching.Contract;
using M1CP.Foundation.Caching.Redis;
using M1CP.Foundation.DependencyInjection;
using StackExchange.Redis;
namespace M1CP.Foundation.Caching.Provider
{
    /// <summary>
    /// Redis cache
    /// </summary>
    [Service(typeof(ICache))]
    class RedisProvider : CacheProviderBase<IDatabase>
    {
        static IDatabase _database;

        /// <summary>
        /// Initialze the cache
        /// </summary>
        /// <returns></returns>
        protected override IDatabase InitCache()
        {
            
          return  _database = RedisConnection.GetDatabase();
        }

       
      
        /// <summary>
        /// Check if cache exist
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public override bool Exists(string key)
        {
            
            return RedisHelper.KeyExists(key);            
             
        }
    
        /// <summary>
        /// Get cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Cache key</param>
        /// <returns></returns>
        public override T Get<T>(string key)
        {
            var value = _database.StringGetAsync(key).Result;
            if (!value.HasValue)
                return default(T);

            return RedisHelper.Deserialize<T>(value);
        }
        /// <summary>
        /// Remove cache
        /// </summary>
        /// <param name="key">Cache key</param>
        public override void Remove(string key)
        {
            RedisHelper.KeyDelete(key);
        }

        /// <summary>
        /// Set cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Cache key</param>
        /// <param name="value">Cache value</param>
        /// <param name="expiration">Cahe expiration</param>
        public override void Set<T>(string key, T value, DateTimeOffset expiration)
        {
            var timeout = expiration.UtcDateTime - DateTime.UtcNow;
            CheckDuration(timeout);
            RedisHelper.SetStringKey<T>(key, value, timeout);
        }

        /// <summary>
        /// Set cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="duration"></param>
        public override void Set<T>(string key, T value, int duration)
        {
            var expire = TimeSpan.FromMinutes(duration);
            CheckDuration(expire);
            RedisHelper.SetStringKey<T>(key, value, expire);
        }

        /// <summary>
        /// Set Cache sliding expriation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="duration"></param>
        public override void SetSliding<T>(string key, T value, int duration)
        {
            var expire = TimeSpan.FromMinutes(duration);
            CheckDuration(expire);
            RedisHelper.SetStringKey<T>(key, value, expire);
        }

        /// <summary>
        /// Check duration
        /// </summary>
        /// <param name="expire"></param>
        private static void CheckDuration(TimeSpan expire)
        {
            if (expire <= TimeSpan.Zero)
            {
                throw new ArgumentException("Expiration value must be greater than zero.", nameof(expire));
            }
        }

        
    }
}
