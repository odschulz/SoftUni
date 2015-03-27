import java.util.Scanner;


public class _04MatchingCarNumbers {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		int num = scan.nextInt();
		int[] nums = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
		int[] letters = new int[] {10, 20, 30, 50, 80, 110, 130, 160, 200, 240};
		int counter = 0;
		for (int i = 0; i < nums.length; i++) {
			for (int j = 0; j < nums.length; j++) {
				for (int k = 0; k < nums.length; k++) {
					for (int l = 0; l < nums.length; l++) {
						for (int m = 0; m < letters.length; m++) {
							for (int n = 0; n < letters.length; n++) {
								if ((j == k && k == l) ^ (i == j && j == k) ^ (i == j && k == l) ^ (i == k && j == l) ^ (i == l && j == k)) {
									int result = 30 + 10 + nums[i] + nums[j] + nums[k] + nums[l] + letters[m] + letters[n];
									if (result == num) {
//										System.out.printf("CA%d%d%d%d", nums[i], nums[j], nums[k], nums[l]);
//										lettersSwitch(letters[m]);
//										lettersSwitch(letters[n]);
//										System.out.print(", ");
										counter++;
									}
								}
							}
						}
					}
				}
			}
		}
		System.out.println(counter);
	}
//	public static void lettersSwitch(int letter){
//		switch (letter) {
//		//10, 20, 30, 50, 80, 110, 130, 160, 200, 240
//		case 10: System.out.print('A');break;
//		case 20: System.out.print('B');break;
//		case 30: System.out.print('C');break;
//		case 50: System.out.print('E');break;
//		case 80: System.out.print('H');break;
//		case 110: System.out.print('K');break;
//		case 130: System.out.print('M');break;
//		case 160: System.out.print('P');break;
//		case 200: System.out.print('T');break;
//		case 240: System.out.print('X');break;
//		}
//	}

}
