using System;


namespace TesterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to dotnet programmng.");
            int count = 45;
            count = count++;
            if(count <= 30)
            {
                while(count < 299)
                {
                    Console.WriteLine("Count = {0}", count);
                }
            }
            Console.WriteLine("Please enter your name :");
            string name = Console.ReadLine();
            Console.WriteLine("Goodmorning {0}", name);
            Console.ReadLine();

        }
    }
}
