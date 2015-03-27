using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Enter side a: ");
        double a = int.Parse(Console.ReadLine());
        Console.Write("Enter side b: ");
        double b = int.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double h = int.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine("Area is: " + area);
    }
}

