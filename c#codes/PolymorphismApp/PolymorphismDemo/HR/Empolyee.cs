namespace HR;

public class Employee
{
    public double basic_sal;
    public double hra;
    public double da;


    public Employee()
    {
        this.basic_sal = 5000;
        this.hra = 3000;
        this.da = 2000;
    }

    public Employee(double basic_sal, double hra, double da)
    {
        this.basic_sal = basic_sal;
        this.hra = hra;
        this.da = da;
    }

    public virtual double calculateSalary()
    {
        return basic_sal + hra + da;
    }

    public override string ToString()
    {
        return $"Basic Salary:{basic_sal},HRA:{hra},DA:{da}";
    }
}