using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using M1CP.Feature.Error.Models;
using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.DependencyInjection;
using Sitecore.Data.Items;

namespace M1CP.Feature.Error.Repositories
{
    [Service(typeof(IError))]
    public class Error: RepositoryBase,IError
    {
        public PageNotFound GetErrorInformation(Item item)
        {
            return ScContext.Cast<PageNotFound>(item);
        }

       
    }
}