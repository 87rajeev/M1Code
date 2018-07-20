using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using M1CP.Foundation.Base.Models;

namespace M1CP.Feature.HeroBanner.Models
{

    public partial interface ICTAButtonLinks : IGlassBase
    {

        [SitecoreField("CTA Title")]
        string CTA_Title { get; set; }


        /// <summary>
        /// The Navigation Title field.
        /// <para></para>
        /// <para>Field Type: Single-Line Text</para>		
        /// <para>Field ID: 13f88561-e76e-463e-a19d-e97c0b1e9502</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField("CTA Link")]
        Link CTA_Link { get; set; }


    }
}