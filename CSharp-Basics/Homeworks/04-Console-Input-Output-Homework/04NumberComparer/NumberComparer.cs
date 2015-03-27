using System;

class NumberComparer
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float greater = Math.Max(a, b);
        Console.WriteLine("Greater: {0}", greater);
    }
}

