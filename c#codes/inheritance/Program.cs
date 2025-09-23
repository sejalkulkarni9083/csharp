using System;
class Employee
{

    public double basic_sal = 30000;
    public double hra = 10000;
    public double da = 5000;
    public double incentives = 2000;
    public double CalculateSalary()
    { return basic_sal + hra + da; }
} 
 
class Manager: Employee 
{ 
   public double CalculateIncentives () 
    { 
     return incentives; 
   } 
}

class Demo {


    static void Main()
    {
        Manager mgr = new Manager();
        double Inc = mgr.CalculateIncentives();
        double sal = mgr.CalculateSalary();
    }
 }