using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.ServiceContracts.ServiceModel
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ServiceResponseErrorInfo
    {
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("ErrorCode")]
        public string ErrorCode { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class ServiceResponseMessageInfo
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class ServiceResponseProperties
    {
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("ErrorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("Response")]
        public string Response { get; set; }
    }
}