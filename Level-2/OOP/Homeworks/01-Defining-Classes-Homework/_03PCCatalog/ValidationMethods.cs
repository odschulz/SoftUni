using System;
using System.Text.RegularExpressions;

namespace _03PCCatalog
{
	public class ValidationMethods
	{
		public static void ValidateValue(object value, string parameter)
		{
			if ((value is string) && (string)value == "") {
				throw new ArgumentNullException ("\"" + parameter + "\"" + "cannot be an empty string!");
			}
			if ((value is decimal) && (decimal)value <= 0) {
				throw new ArgumentNullException ("\"" + parameter + "\"" + "cannot be a negative number or zero!");
			}
		}
	}
}

