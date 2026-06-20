namespace BankManagementSystem.Manager;

using BankManagementSystem.Interfaces;

public class AccountManager : IBankOperation {
    private readonly AccountRepository _repository;

    public BankOperationService(AccountRepository repository)
        {
            _repository = repository;
        }
    public void deposit()
    {
        
    }

}