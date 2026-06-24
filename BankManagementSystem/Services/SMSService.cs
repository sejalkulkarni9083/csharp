
using BankManagementSystem.NotificationService;

public class SMSService : INotificationService{

    public void send(string message){
        Console.WriteLine($"SMS sent: {message}");
    }
}