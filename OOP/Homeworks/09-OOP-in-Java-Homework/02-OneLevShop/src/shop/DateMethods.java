package shop;

import java.security.InvalidParameterException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class DateMethods {
	public static Date parseDate(String dateString) {
	     try {
	         return new SimpleDateFormat("dd-mm-yyyy").parse(dateString);
	     } catch (ParseException e) {
	         throw new InvalidParameterException("Invalid date, Please enter a date in format dd-mm-yyyy.");
	     }
	  }
}
