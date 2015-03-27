import java.util.ArrayList;
import java.util.Scanner;


public class _03ValidUserNames {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String[] line = scan.nextLine().split("[() /\\\\]");
		int sum = 0;
		int position1 = 0;
		int position2 = 0;
		ArrayList<String> valid = new ArrayList<>(); 
		for (int i = 0; i < line.length; i++) {
			if ((line[i].length() >= 3 && line [i].length() <= 25)) {
				if (!(line[i].matches("[0-9](.*)"))) {
					valid.add(line[i]);
				}
			}
		}
		for (int i = 0; i < valid.size()-1; i++) {
				int temp = valid.get(i).length() + valid.get(i+1).length();
				if (temp>sum) {
					sum = temp;
					position1 = i;
					position2 = i+1;
				}
		}
		System.out.println(valid.get(position1));
		System.out.println(valid.get(position2));
	}
	
}
