namespace PaymentProcessingApplication.Accounts
{
    class UpgradeAccountFactory : AccountFactory
    {
        public override Account GetAccount()
        {
            return new UpgradeAccount();
        }
    }
}
