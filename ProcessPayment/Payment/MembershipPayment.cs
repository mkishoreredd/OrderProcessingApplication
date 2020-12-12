using PaymentProcessingApplication.Accounts;

namespace PaymentProcessingApplication.Payment
{
    class MembershipPayment : IPayment
    {
        private Account _account;
        public MembershipPayment()
        {
            AccountFactory factory = new NewAccountFactory();
            _account = factory.GetAccount();
        }
        public string PaymentAction()
        {
            return $"{_account.AccountStatus} and {_account.EmailNotifitcation(_account.ActivationType)}";
        }
    }
}
