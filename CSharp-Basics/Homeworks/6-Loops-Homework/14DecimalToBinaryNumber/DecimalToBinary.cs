using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("n = ");
        long n = long.Parse(Console.ReadLine());
        string output = "";
        do
        {
            output = n % 2 + output;
            n = n / 2;
        } while (n > 0);
        Console.WriteLine(output);
    }
}

