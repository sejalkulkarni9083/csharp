
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using BankManagementSystem.Models;

namespace BankManagementSystem.Repositories;

public class OperationsRepository
{
    public List<Operations> GetAllOperations()
    {
        string filepath = @"/home/tfl/sejal/csharp/BankManagementSystem/Data/operation.json";
        string jsonString = File.ReadAllText(filepath);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        List<Operations>? operations = JsonSerializer.Deserialize<List<Operations>>(jsonString, options);
        return operations ?? new List<Operations>();
    }

    public bool SaveAllOperations(List<Operations> operations)
    {
        bool status = false;
        string fileName = @"/home/tfl/sejal/csharp/BankManagementSystem/Data/operation.json";
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        string jsonString = JsonSerializer.Serialize(operations, options);
        File.WriteAllText(fileName, jsonString);
        status = true;
        return status;
    }
}