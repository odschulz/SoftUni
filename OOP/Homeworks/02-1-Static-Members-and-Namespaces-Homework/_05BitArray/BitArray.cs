using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05BitArray
{
    class BitArray
    {
        private int[] bits;

        public BitArray(int bitCount)
        {
            ValidationMethods.CheckNumberOfBits(bitCount);
            this.bits = new int[bitCount];
        }

        public int this[int index]
        {
            get 
            {
                ValidationMethods.CheckIndex(index, this.bits.Length - 1);
                return this.bits[index]; 
            }
            set
            {
                ValidationMethods.CheckIndex(index, this.bits.Length - 1);
                ValidationMethods.CheckIfValueIsBit(value);
                this.bits[index] = value;
            }
        }

        public string GetAllBits()
        {
            StringBuilder str = new StringBuilder();
            for (int i = this.bits.Length - 1; i >= 0; i--)
            {
                str.Append(this.bits[i]);
            }
            return str.ToString();
        }

        public override string ToString()
        {
            BigInteger result = 0;
            for (int i = 0; i < this.bits.Length; i++)
            {
                if (this.bits[i] == 1)
                {
                    result += BigInteger.Pow(2, i);
                }
            }
            return result.ToString();
        }
    }
}
