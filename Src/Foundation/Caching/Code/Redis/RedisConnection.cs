using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;
namespace M1CP.Foundation.Caching.Redis
{
    public static class RedisConnection
    {
        private static ConnectionMultiplexer _connection;
        private static readonly object SyncObject = new object();

        /// <summary>
        /// connection String
        /// </summary>
        public static ConnectionMultiplexer RedisConnectionString
        {
            get
            {
                if (_connection == null || !_connection.IsConnected)
                {
                    lock (SyncObject)
                    {
                        var configurationOptions = new ConfigurationOptions()
                        {
                            Password = RedisContants.RedisPass,
                            EndPoints = { { RedisContants.RedisIp, Convert.ToInt32(RedisContants.RedisPort) } }
                        };
                        //"192.168.100.37,password=myRedis";
                        _connection = ConnectionMultiplexer.Connect(configurationOptions);
                    }
                }
                return _connection;
            }
        }
        /// <summary>
        /// Get Redis database
        /// </summary>
        /// <param name="database"></param>
        /// <returns></returns>
        public static IDatabase GetDatabase(int? database = default(int?))
        {
            return RedisConnectionString.GetDatabase(database ?? -1);
        }
    }
}
