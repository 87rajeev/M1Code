using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using M1CP.Foundation.Base.Models;

namespace M1CP.Feature.Error.Models
{
    [SitecoreType(AutoMap = true)]
    public class PageNotFound :GlassBase
    {

        [SitecoreField("Title")]
        public virtual string Title { get; set; }

        [SitecoreField("Summary")]
        public virtual string Summary { get; set; }

        [SitecoreField("Description")]
        public virtual string Description { get; set; }

        [SitecoreField("Image")]
        public virtual Image Image { get; set; }

  
    }


}