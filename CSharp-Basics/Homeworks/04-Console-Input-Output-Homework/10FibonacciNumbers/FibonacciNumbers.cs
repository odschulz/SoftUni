using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = 0;                                  // the int variables will overflow if n>47
        int b = 1;
        int c;
        for (int i = 0; i < n; i++)
        {
            Console.Write(a);
            c = a;
            a = b;
            b = c + b;
            if (i <= n-2)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
