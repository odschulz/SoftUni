import java.util.Scanner;


public class _07CountOfBitsOne {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		String nToBin = Integer.toBinaryString(n).replaceAll("0", "");
		System.out.println(nToBin.length());
	}

}
