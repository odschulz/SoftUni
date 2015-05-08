import java.util.Scanner;


public class _05AngleUnitConverter {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in); 	
		int n = input.nextInt();
		for (int i = 1; i <= n; i++) {
			double value = input.nextDouble();
			String measure = input.next();
			if (measure.equals("rad")) {
				System.out.printf("%.6f %s", toDeg(value), "deg");
			}
			else {
				System.out.printf("%.6f %s", toRad(value), "rad");
			}
		}
	}
	public static double toRad(double value){
		return Math.toRadians(value);
	}
	public static double toDeg(double value){
		return Math.toDegrees(value);
	}

}
