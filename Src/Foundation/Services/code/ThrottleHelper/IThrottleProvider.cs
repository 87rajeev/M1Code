using M1CP.Foundation.Caching.Contract;
using M1CP.Foundation.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Services.ThrottleHelper
{
    public interface IThrottleProvider
    {
        /// <summary>
        /// Check the Throttle Allowed.
        /// </summary>
        /// <param name="apiName"></param>
        /// <returns></returns>
        ThrottleUserAccess GetThrottleData(string apiName,string sessionId);
      /// <summary>
      /// Process Throttle by setting the throttle data.
      /// </summary>
      /// <param name="throttleData"></param>
      /// <returns></returns>
        bool ProcessThrottleRequest(ThrottleUserAccess throttleData,string sessionId);
      
        
    }
}