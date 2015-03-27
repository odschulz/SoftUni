import java.security.acl.LastOwnerException;
import java.util.Arrays;
import java.util.Scanner;


public class _05PossibleTrianglesRemake {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		int trianglesCounter = 0;
		while (scan.hasNext()) {
	        if (scan.hasNextDouble()) {
	        	double[] doubles = new double[3];
	            doubles[0] = scan.nextDouble();
	            doubles[1] = scan.nextDouble();
	            doubles[2] = scan.nextDouble();
	            Arrays.sort(doubles);
	            if ((doubles[0] + doubles[1]) > doubles[2]) {
	            	System.out.printf("\n%.2f+%.2f>%.2f", doubles[0], doubles[1], doubles[2]);
	            	trianglesCounter ++;
				}
	        } else if (scan.hasNextInt()) {
	        	int[] ints = new int[3];
	        	ints[0] = scan.nextInt();
	        	ints[1] = scan.nextInt();
	        	ints[2] = scan.nextInt();
	            Arrays.sort(ints);
	            if ((ints[0] + ints[1]) > ints[2]) {
	            	System.out.printf("\n%d+%d>%d", ints[0], ints[1], ints[2]);
	            	trianglesCounter ++;
				}
			} else {
				String lastEntry = scan.next();
				if (lastEntry.equals("End")) {
					break;
				}
			}
	    }
		if (trianglesCounter == 0) {
			System.out.println("No");
		}
	}

}
