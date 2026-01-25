using System;
using HR;
using HR.Interface;

public interface IManagerBenefits : IBonusEligible, IAppraisable
{
    void ApproveLeave();
}
    public class SalesManager : SalesEmployee, 
                            IManagerBenefits,
                            IInterviewPanel,
                            ITrainer

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

        public double CalculateBonus()
    {
        return Bonus;
    }

    public void ConductAppraisal()
    {
        Console.WriteLine("Manager appraisal completed.");
    }

    public void ApproveLeave()
    {
        Console.WriteLine("Leave approved by Sales Manager.");
    }

    public void TakeInterview()
    {
        Console.WriteLine("Sales Manager conducting interview.");
    }

    public void Train()
    {
        Console.WriteLine("Sales Manager training sales team.");
    }
    }
