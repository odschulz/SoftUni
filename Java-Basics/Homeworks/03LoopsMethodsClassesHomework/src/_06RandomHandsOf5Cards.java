import java.util.Random;
import java.util.Scanner;


public class _06RandomHandsOf5Cards {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		String[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J",
				"Q", "K", "A" };
		char[] suits = {'♣', '♦', '♥', '♠'};
		Random rand = new Random();
		for (int i = 0; i < n; i++) {
			System.out.printf("%s%c ", ranks[rand.nextInt(12)+0], suits[rand.nextInt(3)+0]);
			System.out.printf("%s%c ", ranks[rand.nextInt(12)+0], suits[rand.nextInt(3)+0]);
			System.out.printf("%s%c ", ranks[rand.nextInt(12)+0], suits[rand.nextInt(3)+0]);
			System.out.printf("%s%c ", ranks[rand.nextInt(12)+0], suits[rand.nextInt(3)+0]);
			System.out.printf("%s%c ", ranks[rand.nextInt(12)+0], suits[rand.nextInt(3)+0]);
			System.out.println();
		}
	}

}
