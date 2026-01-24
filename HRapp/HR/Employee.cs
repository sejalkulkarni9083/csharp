using System;



namespace Hr
{
    
    public abstract class Employee
    {
        
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public double BasicSalary { get; set; }
        public double Hra{get; set; }

        public Employee( int empId, string firstName, string lastName, double basicSalary)
        {
            EmpId = empId;
            FirstName = firstName;
            LastName = lastName;
            BasicSalary = basicSalary;
        }

        
        public abstract void DoWork();

        
        public virtual double ComputePay()
        {
            return BasicSalary;
        }

    
        public override string ToString()
        {
            return $"Employee Id: {EmpId}, Name: {FirstName} {LastName}";
        }
    }
}