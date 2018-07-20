using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Fields;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace M1CP.Foundation.GlassMapper.Models
{
    public class CustomImage : Image
    {
        public MediaDimension MediaQuery { get; set; }

        public List<ChildMediaDetails> children { get; set; }
    }

    [SitecoreType(AutoMap = true)]
    public class MediaDimension
    {
        [SitecoreField("Dimension")]
        public string Dimension { get; set; }
    }

    public class ChildMediaDetails: MediaDimension
    {
        public string URL { get; set; }

    }
}