namespace EventDrivenApp.Entities; 
public class NotificationManager
{
    public void SendEmail(string message)
    {
        Console.WriteLine("Email has been sent to Account holder");
       
    }

    public void SendSMS(string message)
    {
        Console.WriteLine("SMS has been sent to Account holder");
      
    }

    public void SendWhatsappMessage(string message)
    {
        Console.WriteLine("Whatsapp message has been sent to Account holder");
    
    }
}