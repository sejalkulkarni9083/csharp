using System;

// Polymorphism: allows methods to do different things based on the object that it is acting upon.

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animals makes a sound.");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The cat meows.");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myAnimal.Speak();  
        myDog.Speak();    
        myCat.Speak();    
    }
}