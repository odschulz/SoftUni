using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfKurtovoKonare
{
    class ValidationMethods
    {
        public static void CheckIfStringEmpty(string parameter, string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Parameter " + parameter + " cannot be an empty string or null!");
            }
        }

        public static void CheckIfCustomerIsNull(ICustomer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException("The account must have a customer, with a value different than null!");
            }
        }

        public static void CheckIfNumIsNegativeOrZero(string parameter, decimal value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(parameter + " cannot be a negative number!");
            }
        }

        public static void CheckIfNumIsNegative(string parameter, decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(parameter + " cannot be a negative number!");
            }
        }

        public static void CheckIfNumIsNegative(string parameter, int value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(parameter + " cannot be a negative number!");
            }
        }

    }
}
