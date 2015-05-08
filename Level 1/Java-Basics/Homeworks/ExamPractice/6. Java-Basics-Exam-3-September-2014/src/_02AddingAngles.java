import java.util.Scanner;


public class _02AddingAngles {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		boolean isMatch = false;
		int n = scan.nextInt();
		int[] angles = new int[n];
		for (int i = 0; i < n; i++) {
			angles[i] = scan.nextInt();
		}
		for (int i = 0; i < angles.length; i++) {
			for (int j = i + 1; j < angles.length; j++) {
				for (int k = j + 1; k < angles.length; k++) {
					int sum = angles[i] + angles[j]+ angles[k];
					
					if (sum % 360 == 0) {
						isMatch = true;
						System.out.printf("%d + %d + %d = %d degrees%n", angles[i], angles[j], angles[k], sum);
					}
				}
			}
		}
		if (!isMatch) {
			System.out.println("No");
		}
	}
}
