using System;
using System.Numerics;

class TrailingZeroes
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        //BigInteger factorial = 1;  //if needed to calculate the factorial of n.
        int zeros = 0;
        int result;
        int power = 1;
        //for (int i = 1; i <= n; i++)
        //{
        //    factorial *= i;
        //}
        //Console.WriteLine(factorial);
        do
        {
            result = n / (int)(Math.Pow(5, power));
            zeros += result;
            power++;
        } while (result >= 1);
        Console.WriteLine("Trailing zeros of {0}!: {1}",n , zeros);
        Console.WriteLine();
    }
}

