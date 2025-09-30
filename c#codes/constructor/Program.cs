using System;

class Person
{
   
    public string Name;
    public int Age;

    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

   
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
     
        Person person1 = new Person("Alice", 30);
        person1.DisplayInfo(); 
    }
}