using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CompanyHierarchy
{
    public class ValidationMethods
    {
        public static void CheckIfStringIsEmpty(string parameter, string value)
        {
            if (value == String.Empty)
            {
                throw new ArgumentException(
                    String.Format("The {0} parameter cannot be an empty string!", parameter));
            }
        }

        public static void CheckDecimalIfZeroOrNegative(string parameter, decimal value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    String.Format(
                    "The {0} parameter cannot be zero or a negative number!", parameter));
            }
        }

        public static void CheckIfPersonListIsNull<T>(string parameter, IList<T> list) where T : IPerson
        {
            if (list == null)
            {
                throw new ArgumentNullException(
                    String.Format("The list {0} cannot be null", parameter));
            }
        }

        public static void CheckIfPersonListContains<T>(string parameter, IList<T> list, T person) where T : IPerson
        {
            if (!list.Contains(person))
            {
                throw new ArgumentException(
                    String.Format(
                    "{0} does not contain the person: {1} {2}, ID: {3}",
                    parameter, person.FName, person.LName, person.Id));
            }
        }
    }
}
