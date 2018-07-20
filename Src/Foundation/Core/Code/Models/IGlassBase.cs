using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data;

namespace M1CP.Foundation.Base.Models
{
    using Glass.Mapper.Sc.Configuration;
    using Glass.Mapper.Sc.Configuration.Attributes;

    public partial interface IGlassBase
    {
        ID ItemId { get; set; }

        [SitecoreId]
        Guid Id { get; set; }
        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        [SitecoreInfo(SitecoreInfoType.FullPath)]
        string Path { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [SitecoreInfo(SitecoreInfoType.Name)]
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the template id.
        /// </summary>
        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        Guid TemplateId { get; set; }


       
    }
}
