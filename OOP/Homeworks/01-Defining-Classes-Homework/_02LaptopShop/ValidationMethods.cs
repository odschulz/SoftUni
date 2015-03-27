using System;
using System.Text.RegularExpressions;

namespace _02LaptopShop
{
	public class ValidationMethods
	{
		public static void ValidateValue(object value, string parameter)
		{
			if ((value is string) && (string)value == "") {
				throw new ArgumentNullException ("\"" + parameter + "\"" + "cannot be an empty string!");
			}
			if ((value is float) && (float)value <= 0) {
				throw new ArgumentNullException ("\"" + parameter + "\"" + "cannot be a negative number or zero!");
			}
//			if ((value is int) && (int)value <= 0) {
//				throw new ArgumentOutOfRangeException ("\"" + parameter + "\"" + "cannot be a negative number or zero!");
//			}
			if ((value is decimal) && (decimal)value <= 0) {
				throw new ArgumentNullException ("\"" + parameter + "\"" + "cannot be a negative number or zero!");
			}
		}
	}
}

