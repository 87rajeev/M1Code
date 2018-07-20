
namespace M1CP.Feature.Carousal.Models
{
    using Foundation.Base.Models;
    using Glass.Mapper.Sc.Configuration.Attributes;
    using M1CP.Foundation.GlassMapper.Models;
    using System.Collections.Generic;

    //[SitecoreType(TemplateId = Templates.Carousal.TemplateIdString, AutoMap = true)]  
    public interface ICarousal:ICTA,IItemBase, IGlassBase
    {

        /// <summary>
        /// The Carousal Component field.
        /// <para></para>
        /// <para>Field Type: Tree List</para>		
        /// <para>Field ID: 365BC1C6-9D55-4DCC-B9A7-5907BEDCDE0A</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.Carousal.Fields.CarousalComponentFieldName)]
        IEnumerable<ICarousalComponent> CarousalComponent { get; set; }


        /// <summary>
        /// The Expand CTA field.
        /// <para></para>
        /// <para>Field Type: Check Box</para>		
        /// <para>Field ID: E9BC8247-0F84-466C-BE13-FA136D06FBAB</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.Carousal.Fields.ExpandCTAFieldName)]
        bool ExpandCTA { get; set; }

    }   
   
}
