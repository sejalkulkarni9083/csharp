using System;

class Program
{
    static void ViewNames(params string[] names)
    {
        Console.WriteLine("Names: {0}, {1}, {2}", names[0], names[1], names[2]);
    }

    public static void Main(string[] args)
    {
        ViewNames("Nitin", "Nilesh", "Shrinivas");
    }
}