using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.Base.Models;
using M1CP.Foundation.GlassMapper.Models;
using System.Collections.Generic;

namespace M1CP.Feature.CategoryListing.Models
{

    /// <summary>
    /// CyberGuardianCategories
    /// </summary>
    public interface ICyberGuardianCategories : IGlassBase
    {
        [SitecoreField(Templates.CyberGuardianCategoryListing.Fields.CategoryName)]
        string CategoryName { get; set; }

        [SitecoreField(Templates.CyberGuardianCategoryListing.Fields.CategoryColor)]
        IEnumerable<IStyle> SelectColor { get; set; }
    }
}