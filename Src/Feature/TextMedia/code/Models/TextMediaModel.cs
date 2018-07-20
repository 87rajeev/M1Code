using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Fields;

namespace M1CP.Feature.TextMedia.Models
{
    public class TextMediaModel
    {
        [SitecoreId]
        public Guid ItemId { get; set; }
        [SitecoreField("Title")]
        public virtual string Title { get; set; }
        [SitecoreField("Image")]
        public virtual Image Image { get; set; }

        [SitecoreField("Description")]
        public virtual string Description { get; set; }
    }
    public class TextMediaModelList
    {
        [SitecoreId]
        public Guid ItemId { get; set; }
        [SitecoreField("Title")]
        public virtual string Title { get; set; }
        public virtual IEnumerable<TextMediaModel> Items { get; set; }

        [SitecoreField("Items")]
        public virtual IEnumerable<Guid> ItemIds { get; set; }

        [SitecoreField("Description")]
        public virtual string Description { get; set; }
    }
}