import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;


public class _04OfficeStuff {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		scan.nextLine();
		TreeMap<String, LinkedHashMap<String, Integer>> orders = new TreeMap<>();
		for (int i = 0; i < n; i++) {
			String[] input = scan.nextLine().split("[| -]+");
			String company = input[1];
			int amount = Integer.parseInt(input[2]);
			String product = input[3];
			if (!orders.containsKey(company)) {
				orders.put(company, new LinkedHashMap<String, Integer>());
			}
			LinkedHashMap<String, Integer> amounts = orders.get(company);
			int oldAmount = 0;
			if (amounts.containsKey(product)) {
				oldAmount = amounts.get(product);
			}
			amounts.put(product, oldAmount + amount);
		}
		for (String company : orders.keySet()) {
			System.out.print(company + ": ");
			LinkedHashMap<String, Integer> amounts = orders.get(company);
			boolean first = true;
			for (Map.Entry<String, Integer> pair : amounts.entrySet()) {
				if (!first) {
					System.out.print(", ");
				}
				first = false;
				String product = pair.getKey();
				int amount = pair.getValue();
				System.out.print(product + "-" + amount);
			}
			System.out.println();
		}
	}

}
