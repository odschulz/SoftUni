using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SquareRoot
{
    static class SqrRoot
    {
        public static string GetSqrRoot(int num)
        {
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid number! Number must be a positive integer!");
            }
            return String.Format("{0:0.##}", Math.Sqrt(num));
        }
    }
}
