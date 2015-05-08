using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int j = n % 2;
        if (j == 1)
        {
            Console.WriteLine("Number is odd");
        }
        else
        {
            Console.WriteLine("Number is even");
        }
    }
}
