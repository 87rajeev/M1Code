﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace M1CP.Foundation.Base.Extensions
{
    public static class ObjectExtensions
    {
        
        public static string NoNullToString(this object obj, string nullshow = "")
        {
            string result = nullshow;
            if (obj != null)
            {
                result = obj.ToString();
            }
            return result;
        }
      
        public static T CastTo<T>(this object value)
        {
            object result;
            Type type = typeof(T);
            try
            {
                if (type.IsEnum)
                {
                    result = Enum.Parse(type, value.ToString());
                }
                else if (type == typeof(Guid))
                {
                    result = Guid.Parse(value.ToString());
                }
                else
                {
                    result = Convert.ChangeType(value, type);
                }
            }
            catch
            {
                result = default(T);
            }

            return (T)result;
        }

    
        public static T CastTo<T>(this object value, T defaultValue)
        {
            object result;
            Type type = typeof(T);
            try
            {
                result = type.IsEnum ? Enum.Parse(type, value.ToString()) : Convert.ChangeType(value, type);
            }
            catch
            {
                result = defaultValue;
            }
            return (T)result;
        }
    }
}
