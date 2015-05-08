import java.util.Scanner;

public class _01RectangleArea {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		int b = input.nextInt();
		System.out.println("Area of rectangle is: " + a*b);
	}

}
