using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace M1CP.Feature.Accordion.Models
{
    public interface IFinancialReleaseFiles
    {

        /// <summary>
        /// The Release Title field.
        /// <para></para>
        /// <para>Field Type: Single Line Text</para>		
        /// <para>Field ID: 3EC5C073-4186-4E44-8CC8-0D9A8396D75B</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.FinancialReleaseFiles.Fields.ReleaseTitleFieldName)]
        string ReleaseTitle { get; set; }

        /// <summary>
        /// The Release Image field.
        /// <para></para>
        /// <para>Field Type: Image</para>		
        /// <para>Field ID: A7D6B987-75F8-4CD1-B11D-8B1779053C59</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.FinancialReleaseFiles.Fields.ReleaseImageFieldName)]
        Image ReleaseImage { get; set; }

        /// <summary>
        /// The Release File field.
        /// <para></para>
        /// <para>Field Type: General Link</para>		
        /// <para>Field ID: EA4B37DC-C889-4607-A314-10EE86057E6D</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.FinancialReleaseFiles.Fields.ReleaseFileFieldName)]
        Link ReleaseFile { get; set; }
    }
}
