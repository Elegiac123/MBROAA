using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MRAService
{
    [ServiceContract]
    public interface IMRAService
    {
        [OperationContract]
        bool AllowConsent(long bankID, long d800Number);

        [OperationContract]
        long GetBankID();

        [OperationContract]
        long Get800Number();
    }
}
