
using HR;
namespace HR.Services;

    public interface IEmployeeService
    {
        public double GetSalary(Employee employee);
        public void PerformDuties(Employee employee);
    }
