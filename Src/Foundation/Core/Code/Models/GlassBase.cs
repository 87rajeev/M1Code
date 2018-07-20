using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace M1CP.Foundation.Base.Models
{
    public class GlassBase : IGlassBase
    {
        public ID ItemId { get; set; }
       
        [SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language { get;  set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get;  set; }


        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        [SitecoreInfo(SitecoreInfoType.FullPath)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the template id.
        /// </summary>
        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        public Guid TemplateId { get; set; }
    }
}