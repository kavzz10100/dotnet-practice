using System;
using System.Collections.Generic;

// -------- Base Class --------
public class Shape
{
    public string Name { get; set; }

    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

// -------- Derived Classes --------
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a Circle: {Name}");
    }
}

public class Sphere : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a Sphere: {Name}");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a Rectangle: {Name}");
    }
}

public class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a Triangle: {Name}");
    }
}

public class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a Square: {Name}");
    }
}

// -------- Method Overloading --------
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

// -------- Main Program --------
class Program
{
    static void Main()
    {
        Console.WriteLine("--------- Polymorphism --------");

        // -------- Method Overloading --------
        Console.WriteLine("\nMethod Overloading:");
        Calculator c = new Calculator();
        Console.WriteLine("Addition (2 params): " + c.Add(40, 50));
        Console.WriteLine("Addition (3 params): " + c.Add(40, 50, 60));

        // -------- Method Overriding --------
        Console.WriteLine("\nMethod Overriding (Expanded Shapes):");

        List<Shape> shapes = new List<Shape>
        {
            new Circle { Name = "C1" },
            new Sphere { Name = "S1" },
            new Rectangle { Name = "R1" },
            new Triangle { Name = "T1" },
            new Square { Name = "SQ1" }
        };

        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }
}

----------------------------------------------------------

---------Polymorphism--------

Method Overloading:
Addition(2 params): 90
Addition(3 params): 150

Method Overriding(Expanded Shapes):
Drawing a Circle: C1
Drawing a Sphere: S1
Drawing a Rectangle: R1
Drawing a Triangle: T1
Drawing a Square: SQ1

----------------------------------------------------------------
Improvements Achieved:

 Added more derived classes (Circle,Sphere, Rectangle, Triangle, Square)
 Used collection-based polymorphism (List<Shape>)
 Added property (Name) for realism
 Cleaner and more dynamic output