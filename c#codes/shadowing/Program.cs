

using System;

class Employee
{
    public virtual double CalculateSalary()
    {
        return basic_sal;
    }
} 
class SalesEmployee:Employee 
{ double sales, comm; 
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