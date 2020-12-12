using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessingApplication.Accounts
{
    abstract class AccountFactory
    {
        public abstract Account GetAccount();
    }
}
