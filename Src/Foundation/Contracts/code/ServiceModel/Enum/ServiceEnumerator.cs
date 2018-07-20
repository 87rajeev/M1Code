using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Foundation.ServiceContracts.ServiceModel.Enum
{
    public enum RequestType
    {
        REST,
        SOAP
    }

    public enum MethodType
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public enum ContentType
    {
        JSON,
        XML,
        URLEncoded
    }

    public enum ErrorType
    {
        E_SUCCESS,
        E_FAILED
    }
    public enum APIType : int
    {
        MCS = 1,
        CRM = 2,
        CDM = 3
    }
}