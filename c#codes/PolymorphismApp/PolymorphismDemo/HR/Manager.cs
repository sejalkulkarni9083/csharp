namespace HR;

public class Manager : Employee
{
    public double insentive;

    public Manager()
    {
        this.insentive = 10000;
    }

    public Manager(double basic_sal, double hra, double da, double insentive) : base(basic_sal, hra, da)
    {
        this.insentive = insentive;
    }
    
    public override double calculateSalary()
    {
        return base.calculateSalary() + insentive;
    }
}