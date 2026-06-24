
namespace BankManagementSystem.FundTransfer;

    public interface IFundTransfer
    {
        void TransferFunds(string fromAccount, string toAccount, double amount);
    }
