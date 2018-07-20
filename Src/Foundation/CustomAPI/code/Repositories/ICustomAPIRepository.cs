using M1CP.Foundation.CustomAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace M1CP.Foundation.CustomAPI.Repositories
{
    public interface ICustomAPIRepository
    {
        JsonResult GetSitecoreItem(string id);
        JsonResult GetSitecoreChildItems(string pid, string fields);
        JsonResult GetSitecoreItemRendering(string id, string rid);
        JsonResult GetSitecoreMatchingItems(string fid, string fvalue);
    }
}
