using System;
using System.Web;

namespace M1CP.Foundation.Base.Helpers
{

    public static class CookieHelper
    {

        public static void ClearCookie(string cookiename)
        {
            HttpCookie cookie = new HttpCookie(cookiename);
            cookie.Expires = DateTime.Now.AddYears(-3);
            SetCookie(cookiename, cookie);
        }

        /// <returns></returns>
        public static string GetCookieValue(string cookiename)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[cookiename];
            return cookie?.Value ?? string.Empty;
        }

        public static void SetCookie(string cookiename, string cookievalue, DateTime? expires = null)
        {
            HttpCookie cookie = new HttpCookie(cookiename)
            {
                Value = cookievalue
            };

            if (expires != null)
            {
                cookie.Expires = (DateTime)expires;
            }
            SetCookie(cookiename, cookie);
        }

        private static void SetCookie(string cookieName, HttpCookie cookie)
        {
            HttpContext.Current.Response.Cookies.Remove(cookieName);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }
    }
}
