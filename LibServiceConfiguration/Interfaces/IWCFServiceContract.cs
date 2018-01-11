using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using LibServiceConfiguration.Contracts;

namespace LibServiceConfiguration.Interfaces
{
    [ServiceContract]
   public interface IWCFServiceContract
    {
        [OperationContract] void CreateAddress(Adress _Adress);
        [OperationContract] string GetMessage();
        

    }
}
