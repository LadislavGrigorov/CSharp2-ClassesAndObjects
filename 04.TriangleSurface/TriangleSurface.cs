using System;
//4. Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

class TriangleSurface
{
    static void SurfaceSideAndAltitude()
    {
        Console.Write("Enter side: ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Enter altitude to the side: ");
        double altitude = double.Parse(Console.ReadLine());
        double surface = new double();
        surface = side * altitude / 2;
        Console.WriteLine("The surface is {0}", surface);
    }
    static void SurfaceThreeSides()
    {
        Console.Write("Enter first side: ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second side: ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Enter third side: ");
        double side3 = double.Parse(Console.ReadLine());
        double halfPerimeter = (side1 + side2 + side3) / 2;
        double surface = new double();
        surface = Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
        Console.WriteLine("The surface is {0}", surface);
    }
    static void SurfaceTwoSidesAndAngle()
    {
        Console.Write("Enter first side: ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second side: ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Enter angle between the sides: ");
        double angle = double.Parse(Console.ReadLine());
        double surface = new double();
        surface = (side1 * side2 * Math.Sin(angle)) / 2;
        Console.WriteLine("The surface is {0}", surface);
    }

    static void PrintMenu()
    {
        Console.WriteLine("Enter 1, 2 or 3:");
        Console.WriteLine("Calculate the surface of a triangle by:");
        Console.WriteLine("1. Side and an altitude to it");
        Console.WriteLine("2. Three sides");
        Console.WriteLine("3. Two sides and an angle between them");
    }
    static void Main()
    {
        PrintMenu();
        string userInput = Console.ReadLine();
        switch (userInput)
        {
            case "1":
                SurfaceSideAndAltitude();
                break;
            case "2":
                SurfaceThreeSides();
                break;
            case "3":
                SurfaceTwoSidesAndAngle();
                break;
            default:
                Console.WriteLine("Enter 1, 2 or 3!");
                break;
        }
    }
}
