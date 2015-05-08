import java.util.Scanner;


public class _02Generate3LetterWords {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		char[] letters = input.next().toCharArray();
			for (int i = 0; i < letters.length; i++) {
				for (int j = 0; j < letters.length; j++) {
					for (int k = 0; k < letters.length; k++) {
						System.out.printf("%c%c%c ", letters[i], letters[j], letters[k]);
					}
				}
			}
	}

}
