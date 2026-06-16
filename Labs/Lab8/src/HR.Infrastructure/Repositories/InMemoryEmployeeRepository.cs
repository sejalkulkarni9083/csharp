using HR.Application.Interfaces;
using HR.Domain.Entities;

namespace HR.Infrastructure.Repositories;

public class InMemoryEmployeeRepository : IEmployeeRepository
{
    private readonly List<Employee> _employees = new();

    public void Add(Employee employee)
    {
        _employees.Add(employee);
    }

    public List<Employee> GetAll()
    {
        return _employees;
    }
}