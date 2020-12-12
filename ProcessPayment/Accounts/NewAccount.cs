namespace PaymentProcessingApplication.Accounts
{
    class NewAccount : Account
    {
        private ActivationType _activationType;
        private string _accountStatus;
        public override ActivationType ActivationType => _activationType;

        public override string AccountStatus => _accountStatus;

        public NewAccount()
        {
            _activationType = ActivationType.Activated;
            _accountStatus = "Your account is Activated.";
        }
    }
}
