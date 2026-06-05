namespace LMSApp.Interfaces;

public class SmsNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending SMS notification: {message}");
    }
}