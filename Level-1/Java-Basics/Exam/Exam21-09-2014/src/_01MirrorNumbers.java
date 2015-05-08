import java.util.Scanner;


public class _01MirrorNumbers {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		scan.nextLine();
		String[] nums = scan.nextLine().split(" ");
		for (int i = 0; i < nums.length-1; i++) {
			String reversed = new StringBuilder(nums[i]).reverse().toString();
			for (int j = i+1; j < nums.length; j++) {
				if (reversed.equals(nums[j])) {
					System.out.printf("%s<!>%s", nums[i], nums[j]);
					System.out.println();
				}
			}
		}
	}

}
