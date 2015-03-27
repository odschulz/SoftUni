import java.util.Scanner;

public class _04TheSmallestOf3Numbers {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		double a = input.nextDouble();
		double b = input.nextDouble();
		double c = input.nextDouble();
		double min = Math.min(a, Math.min(b, c));
		if (min % 1 == 0) {
			System.out.println((int)min);
		}
		else {
			System.out.println(min);
		}
	}

}
