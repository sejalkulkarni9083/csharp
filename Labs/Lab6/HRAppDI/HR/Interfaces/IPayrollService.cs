using HR;

namespace HR.Interfaces;

public interface IPayrollService
{
    void GeneratePayslip(Employee emp);
}