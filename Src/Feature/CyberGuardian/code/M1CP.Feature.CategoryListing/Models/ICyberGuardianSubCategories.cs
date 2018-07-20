using Glass.Mapper.Sc.Configuration.Attributes;
using System.Collections.Generic;
using M1CP.Foundation.Base.Models;
using M1CP.Foundation.GlassMapper.Models;

namespace M1CP.Feature.CategoryListing.Models
{
    /// <summary>
    /// Cyber guardian subcategory
    /// </summary>
    public interface ICyberGuardianSubCategories : IGlassBase
    {      
        [SitecoreField(Templates.CyberGuardianCategoryListing.Fields.SubCategoryName)]
        string SubCategoryName { get; set; }

        [SitecoreField(Templates.CyberGuardianCategoryListing.Fields.SubCategoryColor)]
        IEnumerable<IStyle> SelectColor { get; set; }
    }
}