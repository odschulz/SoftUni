using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BitArray
{
    class ValidationMethods
    {
        public static void CheckNumberOfBits(int bitCount)
        {
            if (bitCount < 1 || bitCount > 100000)
            {
                throw new ArgumentOutOfRangeException(
                    "The BitArray can be of size between 1 and 100 000 bits. Please enter a value in the range 1...100000");
            }
        }
        public static void CheckIndex(int index, int length)
        {
            if (index < 0 || index > length)
            {
                throw new ArgumentOutOfRangeException(String.Format(
                    "This BitArray has {0} bits. Please enter a valid index in the range 0...{1}!", length + 1, length));
            }
        }
        public static void CheckIfValueIsBit(int value)
        {
            if (value != 0 && value != 1)
            {
                 throw new ArgumentOutOfRangeException(String.Format(
                     "\"{0}\" is an invalid bit value. Please enter 1 or 0!", value));
            }
        }
    }
}
