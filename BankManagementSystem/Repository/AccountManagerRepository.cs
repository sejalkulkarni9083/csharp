namespace BankManagementSystem.Repository;



public class AccountManagerRepository
{
    public List<Account> GetAllAccounts()
    {
        string fileName = @"/home/tfl/sejal/csharp/BankManagementSystem/Data/Account.Json";
        string jsonString = File.ReadAllText(fileName);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = True };
        List<Account> accounts = JsonSerializer.Deserialize<List<Account>>(jsonString, options);
        return accounts;
    }

    public bool SaveAllAccounts(List<Account> accounts)
    {
        bool status = false;
        string fileName = @"/home/tfl/sejal/csharp/BankManagementSystem/Data/Account.Json";
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        string jsonString = JsonSerializer.Serialize(accounts, options);
        File.WriteAllText(fileName, jsonString);
        status = true;
        return status;
    }
}