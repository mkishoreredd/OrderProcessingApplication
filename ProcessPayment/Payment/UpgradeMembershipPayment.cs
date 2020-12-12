using PaymentProcessingApplication.Accounts;

namespace PaymentProcessingApplication.Payment
{
    class UpgradeMembershipPayment : IPayment
    {
        private Account _account;
        
        public UpgradeMembershipPayment()
        {
            _account = new UpgradeAccountFactory().GetAccount();
        }

        public string PaymentAction()
        {
            return $"{_account.AccountStatus} and {_account.EmailNotifitcation(_account.ActivationType)}";
        }
    }
}
