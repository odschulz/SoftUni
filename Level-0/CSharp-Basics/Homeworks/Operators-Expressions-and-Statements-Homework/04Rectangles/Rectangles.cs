﻿using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2 * width + 2 * height;
        double area = width * height;
        Console.WriteLine("Perimeter = " + perimeter);
        Console.WriteLine("Area = " + area);
    }
}

