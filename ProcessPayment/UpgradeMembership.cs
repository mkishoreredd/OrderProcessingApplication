using PaymentProcessingApplication.Payment;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessingApplication
{
    class UpgradeMembership : Order
    {
        public override IPayment GetPayment()
        {
            return new UpgradeMembershipPayment();
        }
    }
}
