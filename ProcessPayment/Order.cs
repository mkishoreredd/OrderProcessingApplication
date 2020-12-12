using PaymentProcessingApplication.Payment;

namespace PaymentProcessingApplication
{
    abstract class Order
    {
        public abstract IPayment GetPayment();
    }
}
