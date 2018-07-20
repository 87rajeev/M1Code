using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Base.Extensions
{
    public static class DictionaryExtension
    {
        /// <summary>
        /// Tries the get value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dictionary">The dictionary.</param>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public static T TryGetValue<T>(this IDictionary<string, T> dictionary,string key, T defaultValue)
        {
            if (null != dictionary && dictionary.ContainsKey(key))
            {
                return dictionary[key];
            }
            return defaultValue;
        }
    }
}