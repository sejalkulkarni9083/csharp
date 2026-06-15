using HR;
using HR.Services;
using HR.Interfaces;

// Create dependency
//IEmployeeService service = new EmployeeService();
IEmployeeService employeeService = new MockEmployeeService();
IPayrollService payrollService = new PayrollService();

// Inject dependency
HRProcessor processor = new HRProcessor(employeeService, payrollService);

// Create employees
Employee emp1 = new SalesEmployee( 101,
    "Sejal",
    "Kulkarni",
    50000,
    10000,
    200000);
Employee emp2 = new SalesManager( 102,
    "Sanika",
    "Kulkarni",
    80000,
    15000,
    500000,
    20000);

// Process employees
processor.Process(emp1);
processor.Process(emp2);