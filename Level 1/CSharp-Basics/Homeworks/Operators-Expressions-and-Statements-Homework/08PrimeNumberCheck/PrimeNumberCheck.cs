using System;

class PrimeNumberCheck
{
    static void Main()
    {
        // The task says: "Write an expression that checks if given POSITIVE integer number n (n ≤ 100)...". Eventhough there is an example with a negative number, I consider a negative number to be an invalid input as per the above mentioned condition. The number 0 is neither positive, nor negative??, thus left out as well.

        int n;
        do
        {
            Console.Write("Enter a positive integer number between 0 and 100: ");
            n = int.Parse(Console.ReadLine());

        } while (n > 100 || n < 1);
        if (n ==1)
        {
            Console.WriteLine("false");
        }
        else
        {
        bool division = !(n % 2 == 0 || n % 3 == 0);
        bool exceptions = (n == 2 || n == 3);
        bool primeNumber = division || exceptions;
        Console.WriteLine(primeNumber);
        }
    }
}

