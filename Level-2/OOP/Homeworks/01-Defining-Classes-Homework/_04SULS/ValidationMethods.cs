using System;
using System.Text.RegularExpressions;

namespace _04SULS
{
	public class ValidationMethods
	{
		public static void ValidateStrOrDigit(object value, string parameter)
		{
			if ((value is string) && (string)value == "") {
				throw new ArgumentNullException ("\"" + parameter + "\"" + "cannot be an empty string!");
			}
			if ((value is int) && (int)value <= 0) {
				throw new ArgumentNullException ("\"" + parameter + "\"" + "cannot be a negative number or zero!");
			}
		}
		public static void ValidateGrade(double grade)
		{
			if (grade < 2 || grade > 6) {
				throw new ArgumentOutOfRangeException ("Invalid average grade. " +
					"Please enter a valid average grade between 2 and 6");
			}
		}
		public static void ValidateStudentNumber(string str)
		{
			Regex regex = new Regex(@"^[0-9]{5}$");
			Match match = regex.Match(str);
			if (!match.Success)
			{
				throw new ArgumentOutOfRangeException("Invalid student number. " +
				                                      "Student numbers should be strings, consisting of 5 integer digits");
			}
		}
	}
}

