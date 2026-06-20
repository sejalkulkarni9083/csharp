namespace BankManagementSystem.Interfaces
{
    public interface IBankOperation
    {
        void Deposit(int accountId, decimal amount);
        void Withdraw(int accountId, decimal amount);
        decimal FundTransfer(int fromAccountId, int toAccountId, decimal amount);
    }
}
