namespace HR.Services;

public class HRProcessor{
   public readonly IEmployeeService _employeeService;

   public HRProcessor(IEmployeeService employeeService)
   {
       _employeeService = employeeService;  //constructor injection
   }

    public void Process(Employee employee)
    {
        double salary = _employeeService.GetSalary(employee);
        Console.WriteLine(employee);
        Console.WriteLine("Final Salary: " + salary);
    }
}