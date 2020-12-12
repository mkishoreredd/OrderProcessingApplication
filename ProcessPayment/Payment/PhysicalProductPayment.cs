using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessingApplication.Payment
{
    class PhysicalProductPayment : IPayment
    {
        public string PaymentAction()
        {
            return $"{GeneratePackingSlip()}{Environment.NewLine}{CommissionPaymentToAgent()}";
        }

        public string GeneratePackingSlip()
        {
            return "Generated Packing slip for shipping.";
        }

        public string CommissionPaymentToAgent()
        {
            return "Generated Commission Payment to the Agent.";
        }
    }
}
