using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BitArray
{
    class BitArrayTest
    {
        public static void Main(string[] args)
        {
            BitArray bits = new BitArray(8);
            bits[7] = 1;
            Console.WriteLine("Number: " + bits);
            Console.WriteLine("Bits: " + bits.GetAllBits());
        }
    }
}
