using System;
using System.Reflection;

public class Circle
{
    private double radius;

    // Konstruktor som tar radien som parameter
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Metod för att beräkna arean på cirkeln
    public double GetArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
    public double GetCircumfrence()
    {
        return radius * (Math.PI * 2);
    }
    public double GetVolume()
    {
        return (4 * Math.PI * Math.Pow(radius, 3)) / 3;
    }
}

public class Triangle
{
    private double baseLength;
    private double height;

    // Konstruktor som tar basen, höjden och prismans längd som parametrar
    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    // Metod för att beräkna arean på triangeln
    public double GetArea()
    {
        return (baseLength * height) / 2;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(10);
        Console.WriteLine("Arean av cirkeln är: " + circle.GetArea());
        Console.WriteLine("Omkretsen av cirkeln är:" + circle.GetCircumfrence());
        Console.WriteLine("Volymen av cirkeln är: " + circle.GetVolume());

        Triangle triangle = new Triangle(5, 5);
        Console.WriteLine("Arean av cirkeln är: " + triangle.GetArea());
    }
}