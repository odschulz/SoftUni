using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01School
{
    public class ValidationMethods
    {
        public static void CheckIfStringNullOrEmpty(string parameter, string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(
                    String.Format("The parameter {0} cannot be null or an empty string!", parameter));
            }
        }

        public static void CheckIfStringEmpty(string parameter, string value)
        {
            if (value == String.Empty)
            {
                throw new ArgumentException(
                    String.Format("The parameter {0} cannot be an empty string!", parameter));
            }
        }

        public static void CheckIfValueExistsInList<T>(string parameter, T value, List<T> list)
        {
            if (list.Contains(value))
            {
                throw new ArgumentException(
                    String.Format("{0} already exists in the {0} list", parameter));
            }
        }

        public static void CheckIfZeroOrNegative(string parameter, int value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    String.Format("Parameter {0} cannot be a negative number or zero!", value));
            }
        }

        public static void CheckIfListIsNull<T>(string parameter, IList<T> list) where T : IDetailable
        {
            if (list == null)
            {
                throw new ArgumentNullException(parameter + "cannot be null!");
            }
        }
    }
}
