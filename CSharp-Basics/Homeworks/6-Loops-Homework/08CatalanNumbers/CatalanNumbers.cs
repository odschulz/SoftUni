using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter n (1 < n < 100): ");
        //I include '0' as there is an example with 0 in the description and the Catalan number 0 is 1
        int n = int.Parse(Console.ReadLine());
        if (0 <= n && n < 100)
        {
            BigInteger facotrial2n = 1;
            BigInteger factorialNPlus1 = 1;
            BigInteger factorialN = 1;
            for (int i = 1; i <= 2*n; i++)
            {
                facotrial2n *= i;
                if (i <= n+1)
                {
                    factorialNPlus1 *= i;
                }
                if (i <= n)
                {
                    factorialN *= i;
                }
            }
            Console.WriteLine(facotrial2n/(factorialNPlus1*factorialN));
        }
        else
        {
            Console.WriteLine("Invalid input");
            return;
        }
    }
}

