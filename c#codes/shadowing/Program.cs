
//shadowing : hides the base class member

using System;

class Employee
{
    public int basic_sal=1000;
    public virtual double CalculateSalary()
    {
        return basic_sal;
    }
} 
class SalesEmployee:Employee 
{
    double sales = 20000;
    double comm = 0.1; 
  public new double CalculateSalary () 
     {return basic_sal+ (sales * comm) ;} 
}

class Program
{
    static void Main()
    {
        SalesEmployee sper = new SalesEmployee();
        Double salary = sper.CalculateSalary();
        Console.WriteLine(salary);
    }
}