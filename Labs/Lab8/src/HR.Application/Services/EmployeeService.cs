using HR.Application.Interfaces;
using HR.Domain.Entities;

namespace HR.Application.Services;

public class EmployeeService
{
    private readonly IEmployeeRepository _repository;

    public EmployeeService(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public void Hire(Employee employee)
    {
        _repository.Add(employee);
    }

    public List<Employee> GetEmployees()
    {
        return _repository.GetAll();
    }
}