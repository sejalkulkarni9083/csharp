namespace HR;

public class SalesEmployee : Employee
{
    public double target;
    public double bonus;


    public SalesEmployee()
    {
        this.target = 100000;
        this.bonus = 5000;
    }

    public SalesEmployee(double basic_sal, double hra, double da, double target, double bonus) : base(basic_sal, hra, da)
    {
        this.target = target;
        this.bonus = bonus;
    }

    public override double calculateSalary()
    {
        return base.calculateSalary() + bonus;
    }

    public override string ToString()
    {
        return base.ToString() + $"Target:{target},Bonus:{bonus}";
    }
}