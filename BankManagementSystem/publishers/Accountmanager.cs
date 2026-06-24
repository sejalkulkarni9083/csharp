
using BankManagementSystem.Deposit;
using BankManagementSystem.Withdraw;
using BankManagementSystem.FundTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using BankManagementSystem.Repositories;
using BankManagementSystem.Models;
using BankManagementSystem.NotificationService;
using BankManagementSystem.Listeners;

namespace BankManagementSystem.Managers;

public class AccountService : IDepositOperation, IWithdrawOperation, IFundTransfer
{
    public List<Account> accounts { get; set; }
    private INotificationService _service;
    private AccountsRepository accountrepo = new AccountsRepository();
    public List<IAccountListener> listeners = new List<IAccountListener>();

    public AccountService(List<Account> accounts, INotificationService notificationService)
    {
        _service = notificationService;
        this.accounts = accounts;
    }

    public double GetBalance(int accountNo)
    {
        foreach (Account account in accounts)
        {
            if (account.AccountNumber == accountNo)
            {
                account.LastTransactionDate = DateTime.Now;
                Console.WriteLine($"Balance in account for {account.AccountHolderName} is {account.Balance}");
                accountrepo.SaveAllAccounts(accounts);
                return account.Balance;
            }
        }
        return 0;
    }

    // Concrete account-specific operations
    public void DepositToAccount(int accountNumber, double amount)
    {
        var acc = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
        if (acc == null) return;
        acc.Balance += amount;
        acc.LastTransactionDate = DateTime.Now;
        Console.WriteLine($"Balance in account with id {acc.AccountNumber} after deposit is {acc.Balance}");
        CheckBalance(acc);
        accountrepo.SaveAllAccounts(accounts);
    }

    public void WithdrawFromAccount(int accountNumber, double amount)
    {
        var acc = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
        if (acc == null) return;
        acc.Balance -= amount;
        acc.LastTransactionDate = DateTime.Now;
        Console.WriteLine($"Balance in account with id {acc.AccountNumber} after withdraw is {acc.Balance}");
        accountrepo.SaveAllAccounts(accounts);
    }

    // Interface implementations (minimal behavior)
    public void Deposit(double amount)
    {
        if (accounts.Count == 0) return;
        DepositToAccount(accounts[0].AccountNumber, amount);
    }

    public void Withdraw(double amount)
    {
        if (accounts.Count == 0) return;
        WithdrawFromAccount(accounts[0].AccountNumber, amount);
    }

    public void TransferFunds(string fromAccount, string toAccount, double amount)
    {
        if (!int.TryParse(fromAccount, out int fromAcc)) return;
        if (!int.TryParse(toAccount, out int toAcc)) return;

        WithdrawFromAccount(fromAcc, amount);
        DepositToAccount(toAcc, amount);
    }

    private void CheckBalance(Account account)
    {
        IAccountListener listener = new AccountDepartment();
        if (account.Balance < 1000)
        {
            listener.OnUnderBalance(account.Balance);
        }
        else if (account.Balance > 100000)
        {
            listener.OnOverBalance(account.Balance);
        }
    }
}
