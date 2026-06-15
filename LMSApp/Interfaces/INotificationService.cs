namespace LMSApp.Interfaces;

// Interface for sending notifications
public interface INotificationService
{
    void SendNotification(string message);
}