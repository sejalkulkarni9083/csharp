using HR;
using HR.Interfaces;

namespace HR.Services;

public class MockEmployeeService : IEmployeeService
{
    public double GetSalary(Employee employee)
    {
        Console.WriteLine("Mock salary calculation.");

        return 50000;
    }

    public void PerformDuties(Employee employee)
    {
        Console.WriteLine("Mock duties performed.");
    }
}