using StackExchange.Redis;
using System;
using System.Linq;
using M1CP.Foundation.Services.Repository;

namespace M1CP.Foundation.Services.Helper
{
    public static class CacheHelper
    {
        static TimeSpan RedisExpireIn = TimeSpan.Parse(CommonText.GetGenericConstant("RedisTimespan"));

        private static IDatabase _database
        {
            get
            {
                return (IDatabase)System.Web.HttpContext.Current.Application["RedisDBGlobalVar"];
            }
        }

        private static IServer _server
        {
            get
            {
                return (IServer)System.Web.HttpContext.Current.Application["RedisServerGlobalVar"];
            }
        }

        public static bool Exists(string key)
        {
            try
            {
                if (_database != null && _database.IsConnected(key))
                {
                    return _database.KeyExists(key);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //Log.Error("Error in checking data - " + ex.Message, ex);
                return false;
            }
        }

        public static T Get<T>(string key)
        {
            ISerializer _serializer = new JsonSerializer();
            try
            {
                if (_database != null && _database.IsConnected(key))
                {
                    return _serializer.Deserialize<T>(_database.StringGet(key));
                }
                else
                {
                    return _serializer.Deserialize<T>(null);
                }
            }
            catch (Exception ex)
            {
                //Log.Error("Error in getting data - " + ex.Message, ex);
                return _serializer.Deserialize<T>(null);
            }
        }

        public static bool Set<T>(string key, T value)
        {
            try
            {
                if (_database != null && _database.IsConnected(key))
                {
                    ISerializer _serializer = new JsonSerializer();
                    return _database.StringSet(key, _serializer.Serialize(value), RedisExpireIn);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //Log.Error("Error in setting data - " + ex.Message, ex);
                return false;
            }
        }

        public static bool Remove(string key)
        {
            try
            {
                if (_database != null && _database.IsConnected(key))
                {
                    return _database.KeyDelete(key);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //Log.Error("Error in Removing single key data - " + ex.Message, ex);
                return false;
            }
        }

        public static void RemoveAllKeys(string cacheKeyForPatternSearch)
        {
            try
            {
                if (_server != null)
                {
                    RedisKey[] keys = _server.Keys(pattern: cacheKeyForPatternSearch + "*").ToArray<RedisKey>();
                    _database.KeyDeleteAsync(keys);
                }
            }
            catch (Exception ex)
            {
               
            }
        }

        public static T GetOrSetInCache<T>(string cacheKey, Func<T> getItemCallback) where T : class
        {
            T item = null;
            if (Exists(cacheKey))
            {
                item = Get<T>(cacheKey);
                //Log.Info("Got value from cache for Cache key - " + cacheKey + ". Date time - " + DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ss-fff"));
            }
            else
            {
                item = getItemCallback();
                Set<T>(cacheKey, item);
               // Log.Info("Added value to cache, Cache key - " + cacheKey + ". Date time - " + DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ss-fff"));
            }
            return item;
        }

        public static bool ExtendCachedKeysExpiry(string cacheKeyForPatternSearch)
        {
            if (_server != null && _database != null)
            {
                RedisKey[] Allkeys = _server.Keys(pattern: cacheKeyForPatternSearch + "*").ToArray<RedisKey>();
                if (Allkeys != null && Allkeys.Any())
                {
                    foreach (var key in Allkeys)
                    {
                        _database.KeyExpire(key, RedisExpireIn);
                    }
                    return true;
                }
            }
            return false;
        }
    }
}