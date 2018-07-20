using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Base.Models
{
    public class AngularRenderingModel
    {
        public string NgDirective { get; set; }
        public string RenderingItemId { get; set; }
        public string DatasourceItemId { get; set; }
        public object Data { get; set; }
    }
}