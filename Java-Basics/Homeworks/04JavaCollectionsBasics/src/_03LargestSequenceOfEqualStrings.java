import java.util.Scanner;


public class _03LargestSequenceOfEqualStrings {
	public static void main(String[] args) {
		// 1 1 1 1 2 2 2 3 3
		Scanner scan = new Scanner(System.in);
		String inputLine = scan.nextLine();
		String[] words = inputLine.split(" ");
		String word = words[0];
		int tempCounter = 1;
		int counter = 1;
		for (int i = 0; i < words.length - 1; i++) {
			if (words[i].equals(words[i+1])) {
				tempCounter +=1;
				if (tempCounter > counter) {
					word = words[i];
					counter = tempCounter;
				}
			} else {
				if (tempCounter > counter) {
					word = words[i];
					counter = tempCounter;
					tempCounter = 1;
				} else {
					tempCounter = 1;
				}
			}
		}
		for (int i = 0; i < counter; i++) {
			System.out.print(word + " ");
			
		}
	}

}
