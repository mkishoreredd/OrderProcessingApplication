namespace PaymentProcessingApplication.Payment
{
    class VideoPayment : IPayment
    {
        public string PaymentAction()
        {
            return $"Added a free \"First Aid\" video to the packing slip (the result of a court decision in 1997)";
        }
    }
}
