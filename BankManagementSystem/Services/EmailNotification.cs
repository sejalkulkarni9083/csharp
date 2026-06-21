namespace BankManagementSystem.Services;

    public class EmailNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }

