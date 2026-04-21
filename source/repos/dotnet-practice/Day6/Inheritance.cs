using System;

// Base class
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

// Single Inheritance
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

// Multilevel Inheritance
public class Puppy : Dog
{
    public void Weep()
    {
        Console.WriteLine("Puppy weeps");
    }
}

// Hierarchical Inheritance
public class Lion : Animal
{
    public void Hunt()
    {
        Console.WriteLine("Lion hunts animals");
    }
}

public class Deer : Animal
{
    public void Run()
    {
        Console.WriteLine("Deer runs fast");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--------- Inheritance --------");

        Console.WriteLine("\nSingle Inheritance:");
        Dog d = new Dog();
        d.Eat();
        d.Bark();

        Console.WriteLine("\nMultilevel Inheritance:");
        Puppy pup = new Puppy();
        pup.Eat();
        pup.Bark();
        pup.Weep();

        Console.WriteLine("\nHierarchical Inheritance:");
        Lion lion = new Lion();
        lion.Eat();
        lion.Hunt();

        Deer deer = new Deer();
        deer.Eat();
        deer.Run();
    }
}

-----------------------------
expexted output:

--------- Inheritance --------

Single Inheritance:
Animal is eating
Dog is barking

Multilevel Inheritance:
Animal is eating
Dog is barking
Puppy weeps

Hierarchical Inheritance:
Animal is eating
Lion hunts animals
Animal is eating
Deer runs fast

-------------------------------------------------------

Improvements Achieved

Successfully implemented single, multilevel, and hierarchical inheritance.
Improved class and method naming using PascalCase conventions.
Enhanced code readability with clear structure and meaningful output messages.
Corrected terminology (e.g., Inheritance, Hierarchy) for professional presentation.
Organized class relationships clearly to demonstrate parent-child hierarchy effectively.

