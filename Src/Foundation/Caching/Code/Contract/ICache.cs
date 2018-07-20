using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Foundation.Caching.Contract
{
    public interface ICache
    {
       
        
       /// <summary>
        /// Insert value into the cache using
        /// appropriate name/value pairs WITH a cache duration set in minutes
        /// </summary>
        /// <typeparam name="T">Type of cached item</typeparam>
        /// <param name="key">Item to be cached</param>
        /// <param name="value">Name of item</param>
        /// <param name="duration">Cache duration in minutes with sliding expiration</param>
        void SetSliding<T>(string key, T value, int duration);

        

        /// <summary>
        /// Returns a value indicating if the key exists in at least one cache layer configured in CacheManger, 
        /// without actually retrieving it from the cache.
        /// </summary>
        /// <param name="key">Item to be cached</param>
        /// <returns>True if the key exists, False otherwise.</returns>
        bool Exists(string key);

        /// <summary>
        /// Remove item from cache
        /// </summary>
        /// <param name="key">Name of cached item</param>        
        void Remove(string key);


        /// <summary>
        /// Get or Set the Cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Cache Key</param>
        /// <param name="valFunction">Cache Value</param>
        /// <param name="duration">Duration of cache</param>
        /// <returns></returns>
        T GetOrSet<T>( string key,Func<T>  valFunction, int duration) where T : class;
    }
}
