using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        float pi = (float)Math.PI;
        Console.Write("Enter radius: ");
        float r = float.Parse(Console.ReadLine());
        float perimeter = 2 * pi * r;
        float area = pi * r * r;
        Console.WriteLine("Perimeter: {0:0.00}\nArea: {1:0.00}", perimeter, area);
    }
}

