using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MRAService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MRAService" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class MRAService : IMRAService
    {
        private long _bankID;
        private long _800Number;

        public bool AllowConsent(long bankID, long d800Number)
        {
            try
            {
                BankID = bankID;
                D800Number = d800Number;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        private long BankID
        {
            get { return _bankID; }
            set { _bankID = value; }
        }

        private long D800Number
        {
            get { return _800Number; }
            set { _800Number = value; }
        }

        public long GetBankID()
        {
            return BankID;
        }

        public long Get800Number()
        {
            return D800Number;
        }


    }
}
