using BankManagementSystem.Models;
namespace BankManagementSystem.MiniStatement;

public interface IMiniStatement
{
    List<Operations> GetMiniStatement(string accountId);
}

