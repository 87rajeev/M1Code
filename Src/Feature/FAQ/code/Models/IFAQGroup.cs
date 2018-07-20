using Glass.Mapper.Sc.Configuration.Attributes;
using System.Collections.Generic;

namespace M1CP.Feature.FAQ.Models
{
    [SitecoreType(AutoMap = true)]
    public interface IFAQGroup
    {
        [SitecoreField(Templates._FAQ_Group.Fields.Group_MembersFieldName)]        
        IEnumerable<IFAQ> GroupMember {get; set;}
    }
}