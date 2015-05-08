using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02HumanStudentAndWorker
{
    public class ValidationMethods
    {
        public static void CheckIfStringEmpty(string parameter, string value)
        {
            if (value == String.Empty)
            {
                throw new ArgumentException("Parameter \"{0}\" cannot be an empty string!", parameter);
            }
        }

        public static void ValidateFacultyNumber(string value)
        {
            var pattern = @"^[A-Za-z0-9]{5,10}$";
            var match = Regex.Match(value, pattern);
            if (!match.Success)
            {
                throw new ArgumentOutOfRangeException(
                    "Invalid faculty number! A faculty number must contain between 5 and 10 letters and numbers!");
            }
        }

        public static void CheckIfZeroOrNegative(string parameter, double value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Parameter \"{0}\" cannot be zero or a negative number!", parameter);
            }
        }
    }

}
