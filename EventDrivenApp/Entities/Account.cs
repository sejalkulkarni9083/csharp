using System;
using EventDrivenApp.Delegates;

namespace EventDrivenApp.Entities;

public class Account
{
    public double Balance { get; set; }
    public Sender? notify;

    public event TaxInspector? overBalance;

    public void Withdraw(double amount)
    {
        double calculatedResult = this.Balance - amount;
        this.Balance = calculatedResult;

        string message = "amount has been withdrawn from the account";
        Console.WriteLine(message);            
        notify?.Invoke(message);               
    }

    public void Deposit(double amount)
    {
        double calculatedResult = this.Balance + amount;
        this.Balance = calculatedResult;

        string message = "amount has been deposited to the account";
        Console.WriteLine(message);
        notify?.Invoke(message);

        if (calculatedResult >= 250000)
        {
            overBalance?.Invoke(calculatedResult);
        }
    }
}
