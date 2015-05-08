using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        uint n = uint.Parse(Console.ReadLine());
        for (uint i = 1; i <= n; i++)
        {
            Console.Write(i);
            if (i < n)          // so that it doesn't put a space after the last printed number
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

