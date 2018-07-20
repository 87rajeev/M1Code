using Glass.Mapper.Sc.Configuration.Attributes;

namespace M1CP.Feature.Navigation.Models
{
    public interface IBreadCrumbInfo
    {
        /// <summary>
        /// The Navigation Link field.
        /// <para></para>
        /// <para>Field Type: General Link</para>		
        /// <para>Field ID: 07c62e92-e84f-40ef-b5af-cd7d89ef25fc</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates._BreadCrumbInfo.Fields.BreadCrumbTitleFieldName)]
        string BreadCrumbTitle { get; set; }
    }
}
