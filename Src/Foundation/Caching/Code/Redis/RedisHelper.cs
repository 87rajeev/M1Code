using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace M1CP.Foundation.Caching.Redis
{
    public static class RedisHelper
    {
        static readonly string Connstr = ConfigurationManager.ConnectionStrings["RedisServer"].ConnectionString; // ToDo add the configuraiton of ssp
        static ConnectionMultiplexer _redis;
        static readonly object Locker = new object();
       
        


        /// <summary>
        /// Cache manager
        /// </summary>
        public static ConnectionMultiplexer Manager
        {
            get
            {
                if (_redis == null)
                {
                    lock (Locker)
                    {
                        if (_redis != null) return _redis;

                        _redis = GetManager();
                        return _redis;
                    }
                }

                return _redis;
            }
        }

        /// <summary>
        /// Get cache manager
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        static ConnectionMultiplexer GetManager(string connectionString = null)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                connectionString = connectionString ?? Connstr;
            }

            var options = ConfigurationOptions.Parse(connectionString);
            options.ConnectTimeout = 2000;
            options.KeepAlive = 180;
            options.SyncTimeout = 2000;
            options.ConnectRetry = 3;

            return ConnectionMultiplexer.Connect(options);
        }

       
        #region String 

        /// <summary>
        ///  key value
        /// </summary>
        /// <param name="key">Redis Key</param>
        /// <param name="value"></param>
        /// <param name="expiry"></param>
        /// <returns></returns>
        public static bool SetStringKey(string key, string value, TimeSpan? expiry = default(TimeSpan?))
        {
            var db = Manager.GetDatabase();
            return db.StringSet(key, value, expiry);
        }

        /// <summary>
        ///  key value
        /// </summary>
        /// <param name="arr">key</param>
        /// <returns></returns>
        public static bool SetStringKey(KeyValuePair<RedisKey, RedisValue>[] arr)
        {
            var db = Manager.GetDatabase();
            return db.StringSet(arr);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="obj"></param>
        /// <param name="expiry"></param>
        /// <returns></returns>
        public static bool SetStringKey<T>(string key, T obj, TimeSpan? expiry = default(TimeSpan?))
        {
            string json = JsonConvert.SerializeObject(obj);
            var db = Manager.GetDatabase();
            return db.StringSet(key, json, expiry);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key">Redis Key</param>
        /// <returns></returns>

        public static RedisValue GetStringKey(string key)
        {
            var db = Manager.GetDatabase();
            return db.StringGet(key);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listKey"></param>
        /// <returns></returns>
        public static RedisValue[] GetStringKey(List<RedisKey> listKey)
        {
            var db = Manager.GetDatabase();
            return db.StringGet(listKey.ToArray());
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetObjectKey(string key)
        {
            var db = Manager.GetDatabase();
            return db.StringGet(key).ToString();
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetObjectKey<T>(string key)
        {
            var db = Manager.GetDatabase();

            if ((db.StringGet(key) == RedisValue.Null))
            {
                return "";
            }
            else
            {
                var redisKey = db.StringGet(key);
                return JsonConvert.DeserializeObject<T>(redisKey.ToString()).ToString();
            }
        }

        #endregion

        #region Hash

        /// <summary>
        ///  
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Redis Key</param>
        /// <param name="list"> </param>
        /// <param name="getModelId"></param>
        public static void HashSet<T>(string key, List<T> list, Func<T, string> getModelId)
        {
            List<HashEntry> listHashEntry = new List<HashEntry>();
            foreach (var item in list)
            {
                string json = JsonConvert.SerializeObject(item);
                listHashEntry.Add(new HashEntry(getModelId(item), json));
            }

            var db = Manager.GetDatabase();
            db.HashSet(key, listHashEntry.ToArray());
        }

        /// <summary>
        ///  
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Redis Key</param>
        /// <param name="hasFildValue">RedisValue</param>
        /// <returns></returns>
        public static T GetHashKey<T>(string key, string hasFildValue)
        {
            if (!string.IsNullOrWhiteSpace(key) && !string.IsNullOrWhiteSpace(hasFildValue))
            {
                var db = Manager.GetDatabase();
                RedisValue value = db.HashGet(key, hasFildValue);
                if (!value.IsNullOrEmpty)
                {
                    return JsonConvert.DeserializeObject<T>(value);
                }
            }
            return default(T);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Redis Key</param>
        /// <param name="listhashFields">RedisValue value</param>
        /// <returns></returns>
        public static List<T> GetHashKey<T>(string key, List<RedisValue> listhashFields)
        {
            List<T> result = new List<T>();
            if (!string.IsNullOrWhiteSpace(key) && listhashFields.Count > 0)
            {
                var db = Manager.GetDatabase();

                RedisValue[] value = db.HashGet(key, listhashFields.ToArray());
                foreach (var item in value)
                {
                    if (!item.IsNullOrEmpty)
                    {
                        result.Add(JsonConvert.DeserializeObject<T>(item));
                    }
                }
            }
            return result;
        }

        /// <summary>
        ///  Redis key
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static List<T> GetHashAll<T>(string key)
        {
            var db = Manager.GetDatabase();

            List<T> result = new List<T>();
            RedisValue[] arr = db.HashKeys(key);
            foreach (var item in arr)
            {
                if (!item.IsNullOrEmpty)
                {
                    result.Add(JsonConvert.DeserializeObject<T>(item));
                }
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static List<T> HashGetAll<T>(string key)
        {
            var db = Manager.GetDatabase();

            List<T> result = new List<T>();
            HashEntry[] arr = db.HashGetAll(key);
            foreach (var item in arr)
            {
                if (!item.Value.IsNullOrEmpty)
                {
                    result.Add(JsonConvert.DeserializeObject<T>(item.Value));
                }
            }
            return result;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="key"></param>
        /// <param name="hashField"></param>
        /// <returns></returns>
        public static bool DeleteHase(RedisKey key, RedisValue hashField)
        {
            var db = Manager.GetDatabase();
            return db.HashDelete(key, hashField);
        }

        #endregion

        #region key

        /// <summary>
        ///  
        /// </summary>
        /// <param name="key">redis key</param>
        /// <returns> </returns>
        public static bool KeyDelete(string key)
        {
            var db = Manager.GetDatabase();
            return db.KeyDelete(key);
        }

        /// <summary>
        ///   key
        /// </summary>
        /// <param name="keys">rediskey</param>
        /// <returns> </returns>
        public static long KeyDelete(RedisKey[] keys)
        {
            var db = Manager.GetDatabase();
            return db.KeyDelete(keys);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="key">redis key</param>
        /// <returns></returns>
        public static bool KeyExists(string key)
        {
            var db = Manager.GetDatabase();
            return db.KeyExists(key);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="key"> redis key</param>
        /// <param name="newKey"> redis key</param>
        /// <returns></returns>
        public static bool KeyRename(string key, string newKey)
        {
            var db = Manager.GetDatabase();
            return db.KeyRename(key, newKey);
        }
        #endregion

        #region Search Keys
        public static List<string> SearchKeys(string key)
        {
            List<string> list = null;
            for (int i = 1; i <= 5; i++)
            {
                bool bFlag = KeyExists(key + "_" + i);
                string value = RedisHelper.GetObjectKey(key + "_" + i);

                if (!string.IsNullOrEmpty(value))
                {
                    if (list == null)
                        list = new List<string>();

                    list.Add(value);
                }
            }
            return list;

        }
        #endregion

        #region Serialize/DeSerialize
        public static T Deserialize<T>(byte[] serializedObject)
        {
            if (serializedObject == null)
                return default(T);

            var jsonString = Encoding.UTF8.GetString(serializedObject);
            return JsonConvert.DeserializeObject<T>(jsonString);
        }
        public static byte[] Serialize(object item)
        {
            var jsonString = JsonConvert.SerializeObject(item);
            return Encoding.UTF8.GetBytes(jsonString);
        }
        #endregion
    }
}
