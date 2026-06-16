using HR.Application.Services;
using HR.Infrastructure.Repositories;
using HR.Domain.Entities;

// Manual Dependency Injection
var repository = new InMemoryEmployeeRepository();
var service = new EmployeeService(repository);

// Domain objects
var emp1 = new SalesEmployee(
    1,
    "Sejal",
    "Kulkarni",
    50000,
    5000,
    100000
);
var emp2 = new SalesManager(
    2,
    "John",
    "Doe",
    60000,
    6000,
    120000,
    8000
);

// Use cases
service.Hire(emp1);
service.Hire(emp2);

foreach (var emp in service.GetEmployees())
{
    emp.DoWork();
    Console.WriteLine(emp);
    Console.WriteLine("Salary: " + emp.ComputePay());
}