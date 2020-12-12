namespace PaymentProcessingApplication.Accounts
{
    class UpgradeAccount : Account
    {
        private ActivationType _activationType;
        private string _accountStatus;
        public override ActivationType ActivationType => _activationType;
        public override string AccountStatus => _accountStatus;

        public UpgradeAccount()
        {
            _activationType = ActivationType.Upgraded;
            _accountStatus = "Your account is upgraded";
        }
    }
}
