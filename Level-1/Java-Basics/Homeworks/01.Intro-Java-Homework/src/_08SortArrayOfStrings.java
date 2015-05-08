import java.util.*;

public class _08SortArrayOfStrings {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		scan.nextLine();
		String arrayStr[] = new String[n]; 
		for (int i = 0; i < n; i++) {
			arrayStr[i] = scan.nextLine();
			if (arrayStr[i].isEmpty()) {    //problem description has an empty line in input
				i--;
			}
		}
		Arrays.sort(arrayStr);
		for (String city : arrayStr) {
		System.out.println(city);
		}
	}

}
