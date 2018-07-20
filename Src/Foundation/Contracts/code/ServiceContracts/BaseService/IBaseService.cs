using M1CP.Foundation.ServiceContracts.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Foundation.ServiceContracts.ServiceContracts.BaseService
{
    public interface IBaseService
    {
        string GetData(ServiceRequest serverRequest, ServiceRequest secondaryServerRequest);
    }
}
