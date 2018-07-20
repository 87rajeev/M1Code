using System;
using System.Collections.Generic;
using System.Configuration;

namespace M1CP.Foundation.Caching.Redis
{
    class RedisContants
    {
        /// <summary>
        /// Get Redis ip 
        /// </summary>
        public static string RedisIp
        {
            get
            {
                string _redisIp = ConfigurationManager.AppSettings["RedisIp"];//make changes to get the info from ssp configuration file 
                return _redisIp;
            }
        }

        /// <summary>
        /// Get Redis port
        /// </summary>
        public static string RedisPort
        {
            get
            {
                string _redisPort = ConfigurationManager.AppSettings["RedisPort"]; //make changes to get the info from ssp configuration file 
                return _redisPort;
            }
        }

        /// <summary>
        /// Get Redis password
        /// </summary>
        public static string RedisPass
        {
            get
            {
                string _redisPass = ConfigurationManager.AppSettings["RedisPass"];//make changes to get the info from ssp configuration file 
                return _redisPass;
            }
        }
    }
}
