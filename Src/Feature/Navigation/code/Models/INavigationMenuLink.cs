using Glass.Mapper.Sc.Configuration.Attributes;
using System.Collections.Generic;
using Glass.Mapper.Sc.Fields;
using M1CP.Foundation.Base.Models;

namespace M1CP.Feature.Navigation.Models
{

    /// <summary>
    /// INavigation_Link Interface
    /// <para></para>
    /// <para>Path: /sitecore/templates/User Defined/m1/M1CP/Feature/Navigation/_Navigation Link</para>	
    /// <para>ID: aec8911c-c076-4651-a628-f3f560d94ec5</para>	
    /// </summary>
    [SitecoreType(TemplateId = Templates._Navigation_Link.TemplateIdString)] //, Cachable = true
    public partial interface INavigationMenuLink : IGlassBase
    {

        /// <summary>
        /// The Child Navigation Items field.
        /// <para></para>
        /// <para>Field Type: Treelist</para>		
        /// <para>Field ID: 38c0dac4-eb82-49bf-b801-ec903fefc454</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates._Navigation_Link.Fields.Child_Navigation_ItemsFieldName)]
        //[SitecoreChildren]
        IEnumerable<INavigationMenuLink> Child_Navigation_Items { get; set; }


        /// <summary>
        /// The Navigation Link field.
        /// <para></para>
        /// <para>Field Type: General Link</para>		
        /// <para>Field ID: 07c62e92-e84f-40ef-b5af-cd7d89ef25fc</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates._Navigation_Link.Fields.Navigation_LinkFieldName)]
        Link Navigation_Link { get; set; }


        /// <summary>
        /// The Navigation Title field.
        /// <para></para>
        /// <para>Field Type: Single-Line Text</para>		
        /// <para>Field ID: 13f88561-e76e-463e-a19d-e97c0b1e9502</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates._Navigation_Link.Fields.Navigation_TitleFieldName)]
        string Navigation_Title { get; set; }


    }
}