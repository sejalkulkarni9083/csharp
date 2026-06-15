
using HR;
namespace HR.Services;

    public class EmployeeService : IEmployeeService
    {
        public double GetSalary(Employee employee)
        {
        employee.DoWork();
        return employee.ComputePay();
        }

        public void PerformDuties(Employee employee)
        {
            employee.DoWork();
             Console.WriteLine("Employee duties completed.");
        }
    }
