using System;
using System.Numerics;

class CalculateFactorialNK
{
    static void Main()
    {
        Console.WriteLine("Enter n and k (1 < k < n < 100):");
        Console.Write("k = ");
        uint k = uint.Parse(Console.ReadLine());
        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine());
        if ((k > 1 && n > k) && n < 100)
        {
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            for (uint i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i <= k)
                {
                    factorialK *= i;
                }
            }
            Console.WriteLine(factorialN / factorialK);
        }
        else
        {
            Console.WriteLine("Invalid input");
            return;
        }
    }
}

