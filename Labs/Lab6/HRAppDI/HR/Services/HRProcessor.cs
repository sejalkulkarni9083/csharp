using HR;
using HR.Interfaces;

namespace HR.Services;

public class HRProcessor{
   public readonly IEmployeeService _employeeService;

   private readonly IPayrollService _payrollService;

    public HRProcessor(
        IEmployeeService employeeService,
        IPayrollService payrollService)
    {
        _employeeService = employeeService;
        _payrollService = payrollService;
    }

    public void Process(Employee employee)
    {
        double salary = _employeeService.GetSalary(employee);

        Console.WriteLine(employee);
        Console.WriteLine($"Final Salary: {salary}");

        _payrollService.GeneratePayslip(employee);
    }
}