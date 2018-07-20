using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Services.Models
{
    [SitecoreType(AutoMap = true)]
    public class ThrottleSessionCollection : GlassBase
    {
        [SitecoreField(Templates.Throttle.TemplateName)]
        public virtual IEnumerable<ThrottleUserAccess> ThrottleList { get; set; }
    }
}