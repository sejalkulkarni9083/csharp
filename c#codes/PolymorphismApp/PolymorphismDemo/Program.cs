
namespace HR
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine(emp.ToString());
            Console.WriteLine($"Salary:{emp.calculateSalary()}");

            Manager mgr = new Manager();
            Console.WriteLine(mgr.ToString());
            Console.WriteLine($"Salary:{mgr.calculateSalary()}");

            SalesEmployee salesEmp = new SalesEmployee();
            Console.WriteLine(salesEmp.ToString());
            Console.WriteLine($"Salary:{salesEmp.calculateSalary()}");
        }
    }
}