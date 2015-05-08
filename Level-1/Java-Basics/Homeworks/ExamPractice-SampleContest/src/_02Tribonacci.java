import java.math.BigInteger;
import java.util.Scanner;


public class _02Tribonacci {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		BigInteger t1 = scan.nextBigInteger();
		BigInteger t2 = scan.nextBigInteger();
		BigInteger t3 = scan.nextBigInteger();
		int n = scan.nextInt();
		BigInteger[] nums = new BigInteger[n];
		nums[0] = t1;
		nums[1] = t2;
		nums[2] = t3;	
		
		for (int i = 3; i < n; i++) {
			nums[i] = nums[i-1].add(nums[i-2]).add(nums[i-3]);
		}
		System.out.println(nums[n-1]);
	}

}
