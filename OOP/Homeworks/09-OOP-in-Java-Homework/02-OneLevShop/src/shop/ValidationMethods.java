package shop;

import java.security.InvalidParameterException;
import java.util.Date;

public class ValidationMethods {
	public static void checkIfStringIsNullOrEmpty(String parameter, String str) {
		if (str == null || str.isEmpty()) {
			throw new InvalidParameterException(
					String.format(
							"Object cannot be created. %s cannot be null or an empty string.", 
							parameter));
		}
	}
	
	public static void checkIfNumberIsZeroOrNegative(String parameter, double num) {
		if (num <= 0) {
			throw new InvalidParameterException(String.format(
					"Object cannot be created. %s cannot be zero or a negative number.", 
					parameter));
		}
	}
	
	public static void checkIfNumberIsZeroOrNegative(String parameter, int num) {
		if (num <= 0) {
			throw new InvalidParameterException(String.format(
					"Object cannot be created. %s cannot be zero or a negative number.", 
					parameter));
		}
	}
	
	public static void checkIfNumberIsNegative(String parameter, double num) {
		if (num < 0) {
			throw new InvalidParameterException(String.format(
					"Object cannot be created. %s cannot be a negative number.", 
					parameter));
		}
	}
	
	public static void checkIfNumberIsNegative(String parameter, int num) {
		if (num < 0) {
			throw new InvalidParameterException(String.format(
					"Object cannot be created. %s cannot be a negative number.", 
					parameter));
		}
	}
	
	public static void checkIfDateIsValid(String parameter, Date date) {
		Date now = new Date();
		if (date.before(now) || date == null) {
			throw new InvalidParameterException(String.format(
					"Object cannot be created. %s cannot be earlier than the current date or null.", 
					parameter));
		}
	}
}
