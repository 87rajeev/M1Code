using M1CP.Foundation.Services.Helper;
using M1CP.Foundation.Services.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Services.Models
{
    public class PurchaseRequest : Request
    {
        public int ProductId { get; set; }
        public string RequestUrl { get; set; }

    }
}