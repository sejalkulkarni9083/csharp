namespace BankManagementSystem.Listener;

public interface IAccountListener{
    void OnUnderBalance(double balance);
    void OnOverBalance(double balance);
}