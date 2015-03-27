using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        int c = 1;
        if (a == 0 && b == 0)
        {
            Console.WriteLine("Wrong input");
        }
        else if (a == 0 || b == 0)
        {
            Console.WriteLine("GCD = {0}", Math.Max(a, b));
        }
        else if (a >= b)
        {
            while (c != 0)
            {
                c = a % b;
                a = b;
                b = c;  
            }
            Console.WriteLine("GCD = {0}", a);
        }
        else if (b > a)
        {
            while (c != 0)
            {
                c = b % a;
                b = a;
                a = c;  
            }
            Console.WriteLine("GCD = {0}", b);
        }
    }
}

