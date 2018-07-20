using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.GlassMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.GlassMapper.Models
{
    [SitecoreType(TemplateId = Templates._Style.TemplateIdString, AutoMap = true)]
    public interface IStyle
    {


        /// <summary>
        /// The Style field.
        /// <para></para>
        /// <para>Field Type: Single Line Text</para>		
        /// <para>Field ID: {3FEF19B5-6FE2-433C-BDAC-D5EB95CFF9A5}</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates._Style.Fields.SelectedStyleFieldName)]
        string style { get; set; }

        
    }
}