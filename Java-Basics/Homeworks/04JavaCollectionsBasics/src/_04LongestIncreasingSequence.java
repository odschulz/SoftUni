import java.util.Scanner;


public class _04LongestIncreasingSequence {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String inputLine = scan.nextLine();
		String[] elements = inputLine.split(" ");
		int[] nums = new int[elements.length];
		int tempEnd = 0;
		int end = 0;
		int tempCounter = 0;
		int counter = 0;
		for (int i = 0; i < nums.length; i++) {
			nums[i] = Integer.parseInt(elements[i]);
		}
		for (int i = 0; i < nums.length - 1; i++) {
			if (nums[i] < nums[i+1]) {
				System.out.print(nums[i] + " ");
				tempEnd = i+1;
				tempCounter++;
				if (i == nums.length-2) {
					System.out.print(nums[i+1]);
					if (tempCounter < nums.length-1) {
						tempCounter--;
					}
					
					if (counter < tempCounter) {
						counter = tempCounter;
						end = tempEnd;
					}
				}
			} else {
				System.out.println(nums[i]);
				if (counter < tempCounter) {
					counter = tempCounter;
					end = tempEnd;
					tempCounter = 0;
				}
				if (i == nums.length-2) {
					System.out.print(nums[i+1]);
				}
			}
		}
		System.out.println();
		
		if (counter > 0) {
			System.out.print("Longest: ");
			for (int i = end - counter; i <= end; i++) {
				System.out.print(nums[i] + " ");
			}
		} else {
			System.out.printf("Longest: %d", nums[0]);
		}
	}

}
