using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace M1CP.Foundation.Base.Extensions
{
    public static class DateTimeExtensions
    {
        
        public static string ToSimpDate(this DateTime date, string timeformat = "HH:mm:ss", string dateformat = "yy/MM/dd")
        {
            TimeSpan ts = DateTime.Now - date;
            if (ts.Days == 0)
            {
                return date.ToString(timeformat);
            }
            else
            {
                return date.ToString(dateformat);
            }
        }
        
        public static string ToStringByFormat(this DateTime? date, string format)
        {
            string result = "";
            if (date.HasValue)
            {
                result = date.Value.ToString(format);
            }
            return result;
        }
        public static DateTime ToDateTime(this string s, string format, CultureInfo culture)
        {
             
                var r = DateTime.ParseExact(s: s, format: format, provider: culture);
                return r;
           
        }
    }
}
