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

    private OperationsRepository operationRepo = new OperationsRepository();

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

    public void Deposit(int accountNumber, double amount)
    {
        var acc = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);

        if (acc == null)
        {
            Console.WriteLine("Account not found");
            return;
        }

        acc.Balance += amount;
        acc.LastTransactionDate = DateTime.Now;

        CheckBalance(acc);

        SaveOperation(0, accountNumber, amount, "Deposit");

        accountrepo.SaveAllAccounts(accounts);

        Console.WriteLine($"Amount {amount} deposited successfully");
    }

    public void Withdraw(int accountNumber, double amount)
    {
        var acc = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);

        if (acc == null)
        {
            Console.WriteLine("Account not found");
            return;
        }

        if (acc.Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
            return;
        }

        acc.Balance -= amount;
        acc.LastTransactionDate = DateTime.Now;

        CheckBalance(acc);

        SaveOperation(accountNumber, 0, amount, "Withdraw");

        accountrepo.SaveAllAccounts(accounts);

        Console.WriteLine($"Amount {amount} withdrawn successfully");
    }
    public void TransferFunds(string fromAccount,
                              string toAccount,
                              double amount)
    {
        if (!int.TryParse(fromAccount, out int fromAccNo))
        {
            Console.WriteLine("Invalid sender account");
            return;
        }

        if (!int.TryParse(toAccount, out int toAccNo))
        {
            Console.WriteLine("Invalid receiver account");
            return;
        }

        var sender = accounts.FirstOrDefault(a => a.AccountNumber == fromAccNo);
        var receiver = accounts.FirstOrDefault(a => a.AccountNumber == toAccNo);

        if (sender == null)
        {
            Console.WriteLine("Sender account not found");
            return;
        }

        if (receiver == null)
        {
            Console.WriteLine("Receiver account not found");
            return;
        }

        if (sender.Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
            return;
        }

        sender.Balance -= amount;
        receiver.Balance += amount;

        sender.LastTransactionDate = DateTime.Now;
        receiver.LastTransactionDate = DateTime.Now;

        CheckBalance(sender);
        CheckBalance(receiver);
        SaveOperation(fromAccNo, toAccNo, amount, "Transfer");
        accountrepo.SaveAllAccounts(accounts);

        Console.WriteLine("Fund transferred successfully");
    }

   
    private void SaveOperation(int fromAcc, int toAcc, double amount, string type)
    {
        var operations = operationRepo.GetAllOperations();


        operations.Add(new Operations
        {
            WithdrawAccNum = fromAcc,
            DepositAccNum = toAcc,
            Amount = amount,
            OperationType = type,
            TransactionDate = DateTime.Now

        });

        operationRepo.SaveAllOperations(operations);
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