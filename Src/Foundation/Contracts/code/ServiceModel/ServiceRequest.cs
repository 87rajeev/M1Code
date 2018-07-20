using M1CP.Foundation.ServiceContracts.ServiceModel.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.ServiceContracts.ServiceModel
{
    public class ServiceRequest
    {
        public RequestType ServiceRequestType { get; set; }

        public string ServiceUrl { get; set; }

        public ContentType ServiceContentType { get; set; }

        public MethodType ServiceMethodType { get; set; }

        public string RequestData { get; set; }

        public bool ServerAuthRequired { get; set; }

        public string SOAPAction { get; set; }

        public string CacheKey { get; set; }
    }
}