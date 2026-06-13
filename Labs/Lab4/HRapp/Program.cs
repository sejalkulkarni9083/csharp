using HR.Interface;

using HR;

class Program
{

    static void Main()
    {



        SalesManager manager = new SalesManager(
            101,              
            "John Doe",         
            "Sales",            
            50000,             
            10000,             
            8000,               
            7000               
        );

        IAppraisable appraisable = manager;
        appraisable.ConductAppraisal();

        IBonusEligible bonusEligible = manager;
        Console.WriteLine("Bonus: " + bonusEligible.CalculateBonus());

        IInterviewPanel panel = manager;
        panel.TakeInterview();

        ITrainer trainer = manager;
        trainer.Train();

    }
}

// salesManager.Achieved = 160000;

// Console.WriteLine(salesManager.ToString());
// Console.WriteLine(salesEmployee.ToString());
// salesManager.DoWork();
// salesEmployee.DoWork();
// double totalPay = salesManager.ComputePay();
// Console.WriteLine($"Total Pay: {totalPay}");