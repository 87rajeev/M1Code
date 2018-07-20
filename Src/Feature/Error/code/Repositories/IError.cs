using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Feature.Error.Models;
using Sitecore.Data.Items;

namespace M1CP.Feature.Error.Repositories
{
    [SitecoreType(TemplateId =Templates.PageNotFound.TemplateIdString)]
    public interface IError
    {
        PageNotFound GetErrorInformation(Item item);
    }
}
