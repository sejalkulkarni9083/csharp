
using System;

namespace BankManagementSystem.Listeners;

public class AccountDepartment : IAccountListener
{
    public void OnOverBalance(double balance)
    {
        Console.WriteLine($"Account Department!  Account balance is over the limit. Current balance: {balance}");
    }

    public void OnUnderBalance(double balance)
    {
        Console.WriteLine($"Account Department!  Account balance is under the limit. Current balance: {balance}");
    }
}