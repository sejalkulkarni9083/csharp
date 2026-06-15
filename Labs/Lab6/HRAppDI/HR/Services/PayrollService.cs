using HR;
using HR.Interfaces;

namespace HR.Services;

public class PayrollService : IPayrollService
{
    public void GeneratePayslip(Employee emp)
    {
        Console.WriteLine($"Payslip generated for {emp.FirstName} {emp.LastName}");
    }
}