using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Read 6 numbers from command-line arguments
        int[] numbers = new int[6];
        for (int i = 0; i < 6; i++)
        {
            numbers[i] = int.Parse(args[i]); // convert each argument from string to int
        }

        // 2. Print pairs: first with third, second with fourth, etc.
        for (int i = 0; i < 4; i++) // 6 numbers => 4 pairs
        {
            Console.WriteLine($"{numbers[i]} {numbers[i + 2]}");
        }
    }
}
