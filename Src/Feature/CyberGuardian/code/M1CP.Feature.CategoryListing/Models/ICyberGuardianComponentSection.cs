using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.Base.Models;
using M1CP.Foundation.GlassMapper.Models;
using System.Collections.Generic;

namespace M1CP.Feature.CategoryListing.Models
{
    [SitecoreType(AutoMap = true)]
    public interface ICyberGuardianComponentSection : IImage, IItemBase, IGlassBase
    {       
        [SitecoreField(Templates.CyberGuardianCategoryListing.Fields.SelectCategories)]
        IEnumerable<ICyberGuardianCategories> CyberGuardianCategoryList { get; set; }

        [SitecoreField(Templates.CyberGuardianCategoryListing.Fields.SelectSubCategories)]
        IEnumerable<ICyberGuardianSubCategories> CyberGuardianSubCategoryList { get; set; }
    }
}