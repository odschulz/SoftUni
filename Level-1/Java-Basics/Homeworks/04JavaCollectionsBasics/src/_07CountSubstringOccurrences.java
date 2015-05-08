import java.util.Scanner;


public class _07CountSubstringOccurrences {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String text = scan.nextLine().toLowerCase();
		String pattern = scan.nextLine();
		int counter = 0;
		for (int i = 0; i <= text.length() - pattern.length(); i++) {
			if (text.substring(i, pattern.length()+i).contains(pattern)) {
				counter++;
			}
		}
		System.out.println(counter);
	}

}
