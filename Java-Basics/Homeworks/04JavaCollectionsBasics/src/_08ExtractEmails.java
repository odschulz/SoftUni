import java.util.Scanner;
import java.util.regex.*;


public class _08ExtractEmails {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String inputText = scan.nextLine();
		Pattern emailPattern = Pattern.compile("([_A-Za-z0-9-]+)(\\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9-]+)*(\\.[A-Za-z]{2,})");
		Matcher emailMatcher = emailPattern.matcher(inputText);
		while (emailMatcher.find()) {
			System.out.println(emailMatcher.group());
			
		}
	}

}
