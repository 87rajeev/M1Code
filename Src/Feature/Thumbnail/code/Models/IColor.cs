using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.ThumbnailGradient.Models
{
    [SitecoreType(TemplateId = Templates.ColorItem.TemplateIdString, AutoMap = true)]
    public interface IColor: IGlassBase
    {
        //      Guid ID { get; set; }
        //      string Class { get; set; }

        /// <summary>
        /// The Image field.
        /// <para></para>
        /// <para>Field Type: Image</para>		
        /// <para>Field ID: 1CC8685D-FEF3-48CB-B88F-0FCE1E57B25B</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.ColorItem.Fields.SelectedColorFieldName)]
        string color { get; set; }

        
    }
}