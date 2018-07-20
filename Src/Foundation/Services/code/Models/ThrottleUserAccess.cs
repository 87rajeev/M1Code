using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.Base.Models;
using System.Collections.Specialized;

namespace M1CP.Foundation.Services.Models
{
    [SitecoreType(AutoMap = true)]
    public class ThrottleUserAccess:GlassBase
    {
        [SitecoreField("Throttling Enabled")]
        public virtual bool Throttling { get; set; }

        [SitecoreField("Capacity")]
        public virtual int Capacity { get; set; }
        [SitecoreField("ServiceName")]
        public virtual string ServiceName { get; set; }

        [SitecoreField("ThrottleGroup")]
        public virtual string ThrottleGroup { get; set; }

       
    }
}