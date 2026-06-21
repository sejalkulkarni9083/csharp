namespace AccountListener.Interfaces;

public class AccountsDepartment : IAccountListener {

    public void onUnderBalance(double balance) {
        Console.WriteLine(" Department! Current Balance: " + balance);
    }


    public void onOverBalance(double balance) {
        Console.WriteLine("Department! Current Balance: " + balance);
    }
}