using System;

// Interfaces
public interface ISquare
{
    void AreaOfSquare();
}

public interface IRectangle
{
    void AreaOfRectangle();
}

// Multiple Inheritance using Interfaces
public class Area : ISquare, IRectangle
{
    public void AreaOfSquare()
    {
        Console.WriteLine("This is the area of a square");
    }

    public void AreaOfRectangle()
    {
        Console.WriteLine("This is the area of a rectangle");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--------- Interface (Multiple Inheritance) --------");

        Area a = new Area();
        a.AreaOfSquare();
        a.AreaOfRectangle();
    }
}
----------------------------------------------------------

Expected output:

--------- Interface (Multiple Inheritance) --------
This is the area of a square
This is the area of a rectangle

---------------------------------------------------------

Improvements Achieved

Demonstrated multiple inheritance using interfaces.
Renamed interfaces using standard C# naming convention (ISquare, IRectangle).
Clearly separated method declarations (interfaces) and implementations (class).
Improved code readability with clean structure and meaningful method names.
Ensured proper implementation of all interface methods in the derived class.

