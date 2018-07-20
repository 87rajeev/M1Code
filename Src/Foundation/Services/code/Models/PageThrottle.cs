using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Services.Models
{
    [SitecoreType(AutoMap = true)]
    public class PageThrottle
    {
        [SitecoreField("ThrottleEnabled")]
        public virtual bool ThrottleEnabled { get; set; }

        [SitecoreField("ThrottleCapacity")]
        public virtual string ThrottleCapacity { get; set; }
    }
}