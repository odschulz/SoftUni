import java.util.Scanner;


public class _08CountOfEqualBitPairs {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		String binary = Integer.toBinaryString(n);
		int count = 0;
		for (int i = 1; i < binary.length(); i++) {
			if (binary.charAt(i) == binary.charAt(i-1)) {
				count++;
			}
		}
		System.out.println(count);
	}

}
