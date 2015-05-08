import java.util.Arrays;
import java.util.Scanner;


public class _02PossibleTriangles {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		int counter = 0;
		int loops = 0;
		while (true) {
			String[] nums = scan.nextLine().split(" ");
			if (nums[0].equals("End")) {
				break;
			}
			Arrays.sort(nums);
			if (nums[0].contains(".")) {
				double d1 = Double.parseDouble(nums[0]);
				double d2 = Double.parseDouble(nums[1]);
				double d3 = Double.parseDouble(nums[2]);
				if ((d1+d2) > d3) {
					System.out.printf("\n%.2f+%.2f>%.2f", d1, d2, d3);
					loops++;
				} else {
					counter ++;
				}
			} else {
				int i1 = Integer.parseInt(nums[0]);
				int i2 = Integer.parseInt(nums[1]);
				int i3 = Integer.parseInt(nums[2]);
				if ((i1+i2) > i3) {
					System.out.printf("%d+%d>%d", i1, i2, i3);
					System.out.println();
					loops++;
				} else {
					counter ++;
				}
			}
		}
		if (loops == 0 && counter > 0) {
			System.out.println("No");
		}
	}

}
