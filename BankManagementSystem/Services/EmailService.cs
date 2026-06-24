
using BankManagementSystem.NotificationService;

public class EmailService : INotificationService{

    public void send(string message){
        Console.WriteLine($"Email sent: {message}");
    }
}