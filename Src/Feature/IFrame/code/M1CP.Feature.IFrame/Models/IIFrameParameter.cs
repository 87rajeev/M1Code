using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Feature.IFrame.Models
{
    /// <summary>
    /// IIFrameParameter Interface
    /// <para></para>
    /// <para>Path: /sitecore/templates/User Defined/m1/M1CP/Project/Common/Content Types/IFrame/IFrameParameter</para>	
    /// <para>ID: {0014C676-FBEE-4227-A39E-358A35982670}</para>	
    /// </summary>
    /// 
    [SitecoreType(TemplateId = Templates.IFrameRenderingParameter.TemplateIdString, AutoMap = true)]
    public interface IIFrameParameter
    {
        /// <summary>
        /// The IFrame Rendering ID field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID: 708EFF27-F3A2-401E-8984-0B88BDB351EB</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.IFrameRenderingParameter.Fields.IFrameRenderingIdName)]
        string Id { get; set; }

        /// <summary>
        /// The IFrame Rendering Class field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID: 57B1E6DD-4B5E-4AA7-8EB4-88BE45D760AF</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.IFrameRenderingParameter.Fields.IFrameRenderingClassName)]
        string Class { get; set; }

        /// <summary>
        /// The IFrame Rendering Scrolling field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID: 6ADE665C-8AC5-4D75-BD67-0701CEDC9D17</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.IFrameRenderingParameter.Fields.IFrameRenderingScrollingName)]
        string Scrolling { get; set; }

        /// <summary>
        /// The IFrame Rendering Frameborder field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID: B5AE25DB-5808-4524-BE23-249890CEE98B</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.IFrameRenderingParameter.Fields.IFrameRenderingFrameborderName)]
        string Frameborder { get; set; }

        /// <summary>
        /// The IFrame Rendering Height field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID: 525CE49E-2FD5-4DB3-B7CF-D459085B3E58</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.IFrameRenderingParameter.Fields.IFrameRenderingHeightName)]
        string Height { get; set; }

    }
}
