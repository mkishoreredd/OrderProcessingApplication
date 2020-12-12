using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessingApplication.Payment
{
    class BookPayment : IPayment
    {
        public string PaymentAction()
        {
            return $"{DuplicatePackingSlip()}{Environment.NewLine}{CommissionPaymentToAgent()}";
        }
        public string DuplicatePackingSlip()
        {
            return "Generated duplicate Packing slip for the royalty department.";
        }

        public string CommissionPaymentToAgent()
        {
            return "Generated Commission Payment to the Agent.";
        }

    }
}
