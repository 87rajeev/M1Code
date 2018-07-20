using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Services.Models
{
    public class ThrottleCache
    {
        public string ApiName { get; set; }
        public List<string> ThrottleSessionIds { get; set; }
    }
}