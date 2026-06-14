namespace MathEngineProject;

public class Program
{
    public static void Main(string[] args)
    {
        MathEngine calculation = new MathEngine();

        bool exit = false;
        
        while(!exit)
        {
            Console.WriteLine("-------calculation-------");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Enter your choice:");
            int Choice = int.Parse(Console.ReadLine());


            if (Choice == 5)
            {
                exit = true;
                break;
            }
            
            Console.WriteLine("Enter first number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = double.Parse(Console.ReadLine());

            MathOperation operation;
            switch (Choice)
            {
                case 1:
                    operation = calculation.Add;
                    break;

                case 2:
                    operation = calculation.Subtract;
                    break;

                case 3:
                    operation = calculation.Multiply;
                    break;

                case 4:
                    operation = calculation.Divide;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    continue;
            }

            double result = operation(num1, num2);
            Console.WriteLine("Result: " + result);
        }

    }
}