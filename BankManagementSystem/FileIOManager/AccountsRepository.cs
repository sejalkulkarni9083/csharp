
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using BankManagementSystem.Models;

namespace BankManagementSystem.Repositories;

public class AccountsRepository
{
    public List<Account> GetAllAccounts()
    {
        string filename = @"/home/tfl/sejal/csharp/BankManagementSystem/Data/Accounts.json";
        string jsonString = File.ReadAllText(filename);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        List<Account>? accounts = JsonSerializer.Deserialize<List<Account>>(jsonString, options);
        return accounts ?? new List<Account>();
    }

    public bool SaveAllAccounts(List<Account> accounts)
    {
        bool status = false;
        string fileName = @"/home/tfl/sejal/csharp/BankManagementSystem/Data/Accounts.json";
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        string jsonString = JsonSerializer.Serialize(accounts, options);
        File.WriteAllText(fileName, jsonString);
        status = true;
        return status;
    }
}