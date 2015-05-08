import java.util.Scanner;


public class _05CountAllWords {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String inputLine[] = scan.nextLine().split("[\\W]+");
		System.out.println(inputLine.length);
	}

}
