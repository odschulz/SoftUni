import java.util.ArrayList;
import java.util.Scanner;


public class _09CombineListsOfLetters {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String[] line1 = scan.nextLine().split(" ");
		String[] line2 = scan.nextLine().split(" ");
		ArrayList<Character> output = new ArrayList<>();
		ArrayList<Character> temp = new ArrayList<>();
		for (int i = 0; i < line1.length; i++) {
			output.add(i, line1[i].charAt(0));
			temp.add(i, line1[i].charAt(0));
		}
		for (int i = 0; i < line2.length; i++) {
			if (!(temp.contains(line2[i].charAt(0)))) {
				output.add(line2[i].charAt(0));
			}
		}
		for (Character c : output) {
			System.out.print(c + " ");
		}
	}

}
