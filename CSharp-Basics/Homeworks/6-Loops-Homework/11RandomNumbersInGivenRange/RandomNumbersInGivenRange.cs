using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max (min<=max) = ");
        int max = int.Parse(Console.ReadLine());
        Random r = new Random();
        if (min <= max)
        {
            for (int i = 0; i < n; i++)
            {
                int randomNumber = r.Next(min, max + 1);
                Console.Write("{0} ", randomNumber);
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
            return;
        }
    }
}

