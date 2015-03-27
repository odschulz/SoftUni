import java.util.Scanner;

public class _03PointsInsideAFigure {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		double x = input.nextDouble();
		double y = input.nextDouble();
		boolean inside1 = (x >= 12.5 && x <= 22.5) && (y >= 6 && y <= 8.5);
		boolean inside2 = (x >= 12.5 && x <= 17.5) && (y >= 8.5 && y <= 13.5);
		boolean inside3 = (x >= 20 && x <= 22.5) && (y >= 8.5 && y <= 13.5);
		if (inside1 || inside2 || inside3) {
			System.out.println("Inside");
		}
		else {
			System.out.println("Outside");
		}
		
	}

}
