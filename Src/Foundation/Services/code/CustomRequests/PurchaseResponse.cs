using M1CP.Foundation.Services.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Services.Models
{
    public class PurchaseResponse:Response<PurchaseRequest>
    {
        public int ProductId { get; set; }

        
    }
}