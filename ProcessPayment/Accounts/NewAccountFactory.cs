namespace PaymentProcessingApplication.Accounts
{
    class NewAccountFactory : AccountFactory
    {
        public override Account GetAccount()
        {
            return new NewAccount();
        }
    }
}
