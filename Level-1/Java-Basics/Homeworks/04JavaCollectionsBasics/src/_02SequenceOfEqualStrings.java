import java.util.Scanner;


public class _02SequenceOfEqualStrings {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String inputLine = scan.nextLine();
		String[] elements = inputLine.split(" ");
		for (int i = 0; i < elements.length; i++) {
			if (i == elements.length-1) {
				System.out.println(elements[i]);
				continue;
			}
			System.out.print(elements[i] + " ");
			if (!elements[i].equals(elements[i+1])) {
				System.out.println();
			}
		}
	}
}
