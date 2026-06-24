
namespace BankManagementSystem.Listeners;

public interface IAccountListener
{
    void OnUnderBalance(double balance);
    void OnOverBalance(double balance);
}
