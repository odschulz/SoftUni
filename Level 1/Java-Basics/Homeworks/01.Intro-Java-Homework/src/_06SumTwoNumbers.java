import java.util.Scanner;
public class _06SumTwoNumbers {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		int b = input.nextInt();
		int result = a + b;
		System.out.println("result: " + result);
	}

}
