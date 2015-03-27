using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Enter x:");
        double coordinateX = double.Parse(Console.ReadLine());
        Console.Write("Enter y:");
        double coordinateY = double.Parse(Console.ReadLine());
        double r = 2 * 2;
        bool insideCircle = (Math.Pow(coordinateX, 2) + Math.Pow(coordinateY, 2)) <= r;
        Console.WriteLine(insideCircle);
        
    }
}

