import java.util.Scanner;

public class _06FormattingNumbers {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int a;
		do {
			System.out.print("Enter an integer a (0 ≤ a ≤ 500): ");
			a = input.nextInt();
		} while (0 > a || a > 500);
		System.out.println("Enter a floating number b: ");
		double b = input.nextDouble();
		System.out.println("Enter a floating number c: ");
		double c = input.nextDouble();
		System.out.println();
		String aToHex = Integer.toHexString(a).toUpperCase();
		String aToBin = Integer.toBinaryString(a);
		System.out.printf("|%-10s|", aToHex);
		System.out.printf(String.format("%10s|", aToBin).replace(' ', '0'));
		System.out.printf("%10.2f|", b);
		System.out.printf("%-10.3f|", c);
	}

}
