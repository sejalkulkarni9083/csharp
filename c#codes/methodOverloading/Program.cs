using System;

class Calculator
{
    // Method with 2 int parameters
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded method with 3 int parameters
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Overloaded method with 2 double parameters
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Overloaded method with 1 int and 1 double parameter
    public double Add(int a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine(calc.Add(5, 10));           // Output: 15
        Console.WriteLine(calc.Add(1, 2, 3));         // Output: 6
        Console.WriteLine(calc.Add(2.5, 3.5));        // Output: 6.0
        Console.WriteLine(calc.Add(4, 5.5));          // Output: 9.5
    }
}
