using System;

class MyResource : IDisposable
{
    public MyResource()
    {
        Console.WriteLine("MyResource created.");
    }

    public void Use()
    {
        Console.WriteLine("Using MyResource...");
    }

    public void Dispose()
    {
        Console.WriteLine("MyResource disposed.");
    }

    ~MyResource()
    {
        Console.WriteLine("MyResource finalized.");
    }
}

class Program
{
    static void Main()
    {
        MyResource resource = new MyResource();
        resource.Use();
        resource.Dispose(); // Manually calling Dispose

        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Done.");
    }
}
 