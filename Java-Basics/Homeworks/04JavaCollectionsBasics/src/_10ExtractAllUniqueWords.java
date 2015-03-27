import java.util.Scanner;
import java.util.TreeSet;


public class _10ExtractAllUniqueWords {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String[] input = scan.nextLine().toLowerCase().split("[\\W]+");
		TreeSet<String> output = new TreeSet<>();
		for (String s : input) {
			output.add(s);
		}
		for (String s : output) {
			System.out.print(s + " ");
		}
	}

}
