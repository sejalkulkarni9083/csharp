using System;

class TypeCastingExample
{
    static void Main()
    {
        int x = 543454;   

        long y = x;        // Implicit conversion

       
        short z = (short)x;  // Explicit conversion

        Console.WriteLine("Original int value: " + x);
        Console.WriteLine("Converted to long: " + y);
        Console.WriteLine("Converted to short: " + z);
    }
}