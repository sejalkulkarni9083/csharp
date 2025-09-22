using System;

class Calculator
{
    //method Overloading
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    
    public double Add(double a, double b)
    {
        return a + b;
    }

   
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine(calc.Add(5, 10));           
        Console.WriteLine(calc.Add(1, 2, 3));       
        Console.WriteLine(calc.Add(2.5, 3.5));    
    }
}
