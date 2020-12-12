namespace PaymentProcessingApplication.Accounts
{
    abstract class Account
    {
        public abstract ActivationType ActivationType { get; }
        public abstract string AccountStatus { get; }

        public string EmailNotifitcation(ActivationType activationType)
        {
            return "Email Notification stating that the account is " + activationType.GetDescription();
        }
    }
}
