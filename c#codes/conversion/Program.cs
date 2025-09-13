using System;

public class Conversion
{
    int x = 543454;
    long y = x;          //implicit conversion 
    short z = (short)x;     //explicit conversion                   
    public static void Main(string[] args)
    {
        Console.WrirteLlin(y);
        Console.WrirteLlin(z);
    }
}