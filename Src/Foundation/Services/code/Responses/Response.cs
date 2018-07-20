using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.Services.Responses
{
    public abstract class Response <T> where T : class
    {
        public int Errorcode { get; set; }
        public bool Success { get; set; }

        public T Data { get; set; }
    }
}