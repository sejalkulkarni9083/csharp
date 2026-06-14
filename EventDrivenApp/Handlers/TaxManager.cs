namespace Taxation;

public class TaxManager
{

    //Event handling logic
    
    public void  PayIncomeTax(double amount)
    {
        double calculatedTax=5000;
        Console.WriteLine($"Income Tax : {calculatedTax} is deducted ");
    }

    public void  Block(double amount)
    {
        double fine=5000;
        Console.WriteLine($"Chages : {fine} applied ");
        Console.WriteLine("Banking operations have been suspended");
    }
}