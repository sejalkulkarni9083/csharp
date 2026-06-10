using EventDrivenApp.Entities;
using EventDrivenApp.Delegates;

using Taxation;

public class Program
{
    public static void Main(string[] args)
    {
        NotificationManager notificationManager = new NotificationManager();
        Account account = new Account();
        TaxManager taxmanager = new TaxManager();

        account.notify += notificationManager.SendEmail;
        account.notify += notificationManager.SendSMS;
        account.notify += notificationManager.SendWhatsappMessage;
        account.overBalance += taxmanager.PayIncomeTax;
        account.overBalance += taxmanager.Block;

        account.Balance = 500000;
        //account.Deposit(300000);
        account.Withdraw(100000);
    

    }
}