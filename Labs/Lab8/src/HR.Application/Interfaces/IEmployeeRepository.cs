using System;
using HR.Domain.Entities;

namespace HR.Application.Interfaces;

public interface IEmployeeRepository
{
    public void Add(Employee employee);
    public List<Employee> GetAll();
}