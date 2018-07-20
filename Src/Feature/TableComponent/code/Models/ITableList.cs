using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.Base.Models;
using M1CP.Foundation.GlassMapper.Models;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;


namespace M1CP.Feature.TableComponent.Models
{
    [SitecoreType(AutoMap =true)]
    
    public interface ITableList: IItemBase, IGlassBase
    {
        //[SitecoreField(FieldId = "{EAD90DDC-0603-4384-9EF0-FA23B0C6B5FB}")]
        [SitecoreField(FieldName =Templates.Fields.TableListFieldName)]
        IEnumerable<Item> TableList { get; set; }
    }
}
