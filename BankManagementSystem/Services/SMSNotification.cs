namespace BankManagementSystem.Services;

    public class SMSNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }

