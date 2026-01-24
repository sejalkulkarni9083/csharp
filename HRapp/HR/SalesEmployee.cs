using System;
using Hr;

    public class SalesEmployee : Employee
    {
        public double Incentive { get; set; }
        public double Target { get; set; }
        public double Achieved { get; set; }

      
        public SalesEmployee( int empId, string firstName, string lastName, double basicSalary, double incentive, double target ) 
        : base(empId, firstName, lastName,  basicSalary)
        {
            Incentive = incentive;
            Target = target;
            }

       
        public override void DoWork()
        {
            Console.WriteLine("Sales Employee is selling products and meeting targets.");
        }

        
        public override double ComputePay()
        {
            double totalSalary = BasicSalary;

            
            if (Achieved >= Target)
            {
                totalSalary += Incentive;
            }

            return totalSalary;
        }

        public override string ToString()
        {
            return $"SalesEmployee Incentive: {Incentive}, Target: {Target}, Achieved: {Achieved}, " +
                   base.ToString();
        }
    }
