import java.util.Scanner;

public class _05DecimalToHexadecimal {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		String hex = Integer.toHexString(num).toUpperCase();
		System.out.println(hex);
	}

}
