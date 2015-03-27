using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Fib({0}) is: ", n);
        Fib(n);
        Console.WriteLine();
    }
    static void Fib(int n)
    {
        if (n == 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            BigInteger a = 1;
            BigInteger b = 2;
            BigInteger[] fibonacciArray = new BigInteger[n];
            for (int i = 0; i < n; i++)
            {
                fibonacciArray[i] = a;
                b = a + b;
                a = b - a;
                b = (b - a) + a;
            }
            Console.WriteLine(fibonacciArray[n - 1]);
        }
    }
}