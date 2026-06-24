namespace BankManagementSystem.Deposit;

public interface IDepositOperation
{
    void Deposit(int accountno , double amount);
}