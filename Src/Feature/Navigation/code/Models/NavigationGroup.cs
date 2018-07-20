using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.Base.Models;
using System.Collections.Generic;

namespace M1CP.Feature.Navigation.Models
{
    [SitecoreType(AutoMap = true)]
    public class NavigationGroup : GlassBase
    {
        [SitecoreField(Templates.Navigation.Fields.Select_Navigation_LinksFieldName)]
        public virtual IEnumerable<INavigationMenuLink> Select_Navigation_Links { get; set; }
    }
}