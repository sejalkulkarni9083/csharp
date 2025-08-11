using AsyncApp2.Helper;


Console.WriteLine("Primary Thread:" + Thread.CurrentThread.ManagedThreadId.ToString());

//Asynchronous method
//c# 2.0
//robustness

//task 1:
Action sayWelcome = delegate ()
{

    int count = 786;

    count++;
    Console.WriteLine("Thread ID:" + Thread.CurrentThread.ManagedThreadId.ToString());
    Console.WriteLine($"Count is {count}");
    Console.WriteLine("Welcome to C#");

};



//concise syntax
//task 2:
Action sayHello = () =>
{
    int count = 745;
    count++;
    Console.WriteLine("Thread ID:" + Thread.CurrentThread.ManagedThreadId.ToString());
    Console.WriteLine($"Count is {count}");
    Console.WriteLine("Hello World");
};


//blocking call
sayWelcome();
sayHello();

//define a task

//non-blocking call

Task.Run(static () =>
{
    Console.WriteLine("Thread ID:" + Thread.CurrentThread.ManagedThreadId.ToString());
    Console.WriteLine("Task is running");
    //Tax clculation Logic
    decimal amount = 500000;
    //invoke the delegate
    TaxCalculationDelegate incomeTaxCalculation = new TaxCalculationDelegate(TaxManager.CalculateIncomeTax);
    TaxCalculationDelegate proxyTaxCalculator = incomeTaxCalculation;

    decimal tax = proxyTaxCalculator(amount);
});

Task task1 = Task.Run(() =>
{
    Console.WriteLine("Thread ID : " + Thread.CurrentThread.ManagedThreadId.ToString());
    Console.WriteLine("Welcome to c#");
});