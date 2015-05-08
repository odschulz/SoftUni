using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimesInGivenRange
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        if (endNum < startNum)
        {
            Console.WriteLine("(empty list)");
        }
        List<int> primes = FindPrimesInRange(startNum, endNum);
        for (int i = 0; i < primes.Count; i++)
        {
            Console.Write(primes[i]);
            if (i < primes.Count-1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primesList = new List<int>();
        if (startNum <= 2)
        {
            primesList.Add(2);
            startNum = 3;
        }
        for (int i = startNum; i <= endNum; i++)
        {
            bool isPrime = true;
            for (int j = 2; (j * j) <= i; j++)
            {
                if ((i % j) == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primesList.Add(i);
            }
        }
        return primesList;
    }
}
