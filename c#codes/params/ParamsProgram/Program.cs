int[] marks = new int[] { 90, 80, 70, 60, 50 };

foreach (var mark in marks)
{
    Console.WriteLine(mark);
}

static void ViewNames(params string[] name)
{
    foreach (var n in name)
    {
        Console.WriteLine(n);
    }
}

ViewNames("Alice", "Bob", "Charlie");
Console.WriteLine();