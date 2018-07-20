using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using M1CP.Foundation.GlassMapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Foundation.GlassMapper.Models
{
    /// <summary>
    /// IVideo Interface
    /// <para></para>
    /// <para>Path:/sitecore/templates/User Defined/m1/M1CP/Foundation/Media/_Video</para>	
    /// <para>ID: 06F30964-9090-43C2-A464-AEE216DBEDF6</para>	
    /// </summary>
    [SitecoreType(TemplateId = Templates._Video.TemplateIdString)] //, Cachable = true
    public interface IVideo
    {
        /// <summary>
        /// The Video Link field.
        /// <para></para>
        /// <para>Field Type: General Link</para>		
        /// <para>Field ID: F1ACE96A-391A-44A6-B97A-875ED52755C7</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates._Video.Fields.Video_URLFieldName)]
        Link Video_URL { get; set; }

        /// <summary>
        /// The Video Checkbox field.
        /// <para></para>
        /// <para>Field Type: Checkbox</para>		
        /// <para>Field ID: 6EF85F21-B413-4F6B-80D0-1F88CCAD6E78</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates._Video.Fields.IsVideoFieldName)]
        bool IsVideo { get; set; }

        /// <summary>
        /// The Video Checkbox field.
        /// <para></para>
        /// <para>Field Type: Checkbox</para>		
        /// <para>Field ID: 6EF85F21-B413-4F6B-80D0-1F88CCAD6E78</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates._Video.Fields.Video_PosterFieldName)]
        CustomImage Video_Poster { get; set; }        
    }
}
