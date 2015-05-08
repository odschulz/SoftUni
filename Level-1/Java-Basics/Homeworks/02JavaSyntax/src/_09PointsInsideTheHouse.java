import java.util.Scanner;


public class _09PointsInsideTheHouse {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		double x = input.nextDouble();
		double y = input.nextDouble();
		if (inTriangle(x, y) || inRectangulars(x, y)) {
			System.out.println("Inside");
		}
		else {
			System.out.println("Outside");
		}
	}
	public static boolean inTriangle(double x, double y){
		double aX = 12.5;
		double aY = 8.5;
		double bX = 22.5;
		double bY = 8.5;
		double cX = 17.5;
		double cY = 3.5;
		double abc = Math.abs((aX * (bY - cY) + bX * (cY - aY) + cX * (aY - bY)) / 2.0);
		double pbc = Math.abs((x * (bY - cY) + bX * (cY - y) + cX * (y - bY)) / 2.0);
		double apc = Math.abs((aX * (y - cY) + x * (cY - aY) + cX * (aY - y)) / 2.0);
		double abp = Math.abs((aX * (bY - y) + bX * (y - aY) + x * (aY - bY)) / 2.0);
		if (Math.round(abc) == Math.round(pbc + apc + abp)) {
			return true;
		}
		else {
			return false;
		}
	}
	public static boolean inRectangulars (double x, double y){
		boolean figure1 = (x >= 12.5 && x <= 17.5) && (y >= 8.5 && y <= 13.5);
		boolean figure2 = (x >= 20 && x <= 22.5) && (y >= 8.5 && y <= 13.5);
			if (figure1 || figure2) {
				return true;
			}
			else {
				return false;
			}
	}

}
