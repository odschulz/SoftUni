import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.Scanner;


public class _07DaysBetweenTwoDates {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String inputString1 = input.nextLine();
		String inputString2 = input.nextLine();
		DateTimeFormatter formatter = DateTimeFormatter.ofPattern("d-MM-yyyy");
	    LocalDate date1 = LocalDate.parse(inputString1, formatter);
	    LocalDate date2 = LocalDate.parse(inputString2, formatter);
	    
	    long diff = ChronoUnit.DAYS.between(date1, date2);
	    System.out.println(diff);
	}

}
