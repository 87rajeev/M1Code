using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Base.Entities
{
    /// <summary>
    /// CallContext Class
    /// </summary>
    public class CallContext
    {
        /// <summary>
        /// Creates new instance of CallContext
        /// </summary>
        internal CallContext()
        {
            Site = new SiteContext { SiteName = "Website" };
            User = new UserContext { IsLoggedIn = false };
            Shopping = new ShoppingContext { Enabled = false };
            Request = new RequestContext { Device = Device.Desktop };
        }
        /// <summary>
        /// Current Context Site Information
        /// </summary>
        public SiteContext Site { get; set; }
        /// <summary>
        /// Current Context User Information
        /// </summary>
        public UserContext User { get; set; }
        /// <summary>
        /// Current Context Shopping Information
        /// </summary>
        public ShoppingContext Shopping { get; set; }
        /// <summary>
        /// Current Context Request Information
        /// </summary>
        public RequestContext Request { get; set; }

        /// <summary>
        /// Set Current Context
        /// </summary>
        /// <param name="callContext"></param>
        internal static void SetCurrentContext(CallContext callContext)
        {
            HttpContext.Current?.Items?.Add(Constants.CallContextKey, callContext);
        }
        /// <summary>
        /// Get Current CallContext
        /// </summary>
        public static CallContext Current => (CallContext)HttpContext.Current?.Items?[Constants.CallContextKey];
    }
    public class SiteContext
    {
        public string SiteName { get; set; }
    }
    public class UserContext
    {
        public string UserName { get; set; }
        public bool IsLoggedIn { get; set; }
    }
    public class ShoppingContext
    {
        public bool Enabled { get; set; }
    }
    public class RequestContext
    {
        public string UserAgent { get; set; }
        public Device Device { get; set; }
    }
    public enum Device
    {
        /// <summary>
        /// Default Device - Desktop
        /// </summary>
        Desktop = 0,
        Mobile = 1,
        Tablet = 2
    }
}