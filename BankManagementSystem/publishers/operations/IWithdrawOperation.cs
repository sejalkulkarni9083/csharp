namespace BankManagementSystem.Withdraw;

public interface IWithdrawOperation
{
    void Withdraw(int accountno ,double amount);
}