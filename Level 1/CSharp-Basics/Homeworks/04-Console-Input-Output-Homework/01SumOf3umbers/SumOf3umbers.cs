using System;

class SumOf3umbers
{
    static void Main()
    {
        Console.WriteLine("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Sum is: {0}", a + b + c);
    }
}

