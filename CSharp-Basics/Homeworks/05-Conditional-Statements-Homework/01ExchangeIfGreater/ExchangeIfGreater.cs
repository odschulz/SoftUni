using System;

class ExchangeIfGreater
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("{0} {1}", a, b);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}

