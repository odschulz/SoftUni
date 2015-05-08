using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }

        private static bool IsPrime(long n)
        {
            if ((n & 1) == 0)
            {
                if (n == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= n; i += 2)
            {
                if ((n % i) == 0)
                {
                    return false;
                }
            }
            return n != 1;
        }
    }
}
