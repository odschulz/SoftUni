using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        uint n = uint.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i);
                if (i < n)
                {
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine();
    }
}
