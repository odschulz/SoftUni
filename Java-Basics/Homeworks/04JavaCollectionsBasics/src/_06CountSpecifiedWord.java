import java.util.Scanner;


public class _06CountSpecifiedWord {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String[] line = scan.nextLine().split("[\\W]+");
		String pattern = scan.nextLine();
		int counter = 0;
		for (String word : line) {
			if (word.equalsIgnoreCase(pattern)) {
				counter++;
			}
		}
		System.out.println(counter);
	}

}
