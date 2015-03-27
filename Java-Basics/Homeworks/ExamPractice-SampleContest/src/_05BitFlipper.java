import java.math.BigInteger;
import java.util.Scanner;


public class _05BitFlipper {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		BigInteger n = scan.nextBigInteger();
		String unpaddedBit = n.toString(2);
		String bit1 = unpaddedBit.format("%64s", unpaddedBit).replace(' ', '0');
		StringBuilder bitOutput = new StringBuilder(bit1);
		for (int i = 0; i < bit1.length()-2; i++) {
			if (bit1.charAt(i) == bit1.charAt(i+1) && bit1.charAt(i) == bit1.charAt(i+2)) {
				if (bit1.charAt(i) == '1') {
					bitOutput.setCharAt(i, '0');
					bitOutput.setCharAt(i+1, '0');
					bitOutput.setCharAt(i+2, '0');
					i +=2;
				} else {
					bitOutput.setCharAt(i, '1');
					bitOutput.setCharAt(i+1, '1');
					bitOutput.setCharAt(i+2, '1');
					i +=2;
				}
			}
		}
		String outputBin = bitOutput.toString();
		System.out.println(new BigInteger(outputBin, 2).toString(10));
	}

}
