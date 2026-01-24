using System;

namespace Hr
{
    public class SalesManager : SalesEmployee
    {
        public double Bonus { get; set; }

        public SalesManager(int empId, string firstName,string lastName, double basicSalary, double incentive, double target, double bonus)
         : base(
            empId, firstName, lastName, basicSalary, incentive, target)
        {
            Bonus = bonus;
        }

        
        public override void DoWork()
        {
            Console.WriteLine("Sales Manager is managing team .");
        }

        
        public override double ComputePay()
        {
          
            double salary = base.ComputePay();

            
            salary += Bonus;

            return salary;
        }
        public override string ToString()
        {
            return $"SalesManager Bonus: {Bonus}, " +
                   base.ToString();
        }
    }
}