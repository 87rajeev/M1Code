using M1CP.Foundation.Logging;
using M1CP.Foundation.Services.Helper;
using M1CP.Foundation.Services.Models;
using M1CP.Foundation.Services.ThrottleHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using static M1CP.Foundation.Services.Templates;

namespace M1CP.Foundation.Services.CustomRequests
{
    interface IPurchaseService
    {
        PurchaseResponse GetPurchaseDetails(PurchaseRequest request);
    }
    public class PurchaseService : Responses.Response<PurchaseData>
    {
        
        public PurchaseResponse Get(long purchaseId)
        {
            //HttpClient client = new HttpClient();
            //HttpResponseMessage response = client.GetAsync("http://localhost:49903/api/values").Result;
            //response.EnsureSuccessStatusCode();
            purchaseId.ThrowIfUnassigned("purchaseId");
            return null;
        }
        public PurchaseResponse CreateAsync(PurchaseRequest purchaseRequest)
        {
            purchaseRequest.ThrowIfNull("purchaseRequest");
            return null;
        }
    }
    public class PurchaseData : RequestHandlerBase<PurchaseRequest, PurchaseResponse>
    {
        public override PurchaseResponse Process(PurchaseRequest request)
        {
            //HttpClient client = new HttpClient();
            //HttpResponseMessage response = client.GetAsync("http://localhost:49903/api/values").Result;
            //response.EnsureSuccessStatusCode();
            return base.Process(request);
        }
        public override PurchaseResponse HandleRequest(PurchaseRequest request)
        {
            throw new NotImplementedException();
        }
        

        protected override PurchaseResponse Execute(PurchaseRequest request)
        {
            return null;     
        }
    }
}

