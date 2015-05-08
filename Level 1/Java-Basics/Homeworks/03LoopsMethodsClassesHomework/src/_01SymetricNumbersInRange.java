import java.util.Scanner;

public class _01SymetricNumbersInRange {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int a, b;
		do {
			System.out.println("Enter 2 numbers (0 ≤ a ≤ b ≤ 999): ");
			a = input.nextInt();
			b = input.nextInt();
		} while ((a<0 || a>998) || (a>b || b>999));
		for (int i = a; i <= b; i++) {
			if (i <= 11 && i != 10) {
				System.out.print(i + " ");
			}
			else if (i < 100) {
				if (i % 10 == i / 10) {
					System.out.print(i + " ");
				}
			}
			else {
				if (i % 10 == i / 100) {
					System.out.print(i + " ");
				}
			}
		}
		System.out.println();
	}

}
