using Glass.Mapper.Sc;
using Glass.Mapper.Sc.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Base.Repositories
{
    public class RepositoryBase
    {
        public ISitecoreContext ScContext;
        public RepositoryBase()
        {
            ScContext = SitecoreContextFactory.Default.GetSitecoreContext();
        }
    }
}