import java.util.Collections;
import java.util.Scanner;
import java.util.TreeSet;

import javax.swing.plaf.basic.BasicTreeUI.TreeCancelEditingAction;


public class _03Biggest3PrimeNumbers {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String input = scan.nextLine();
		String[] numbers = input.split("[( )]+");
		TreeSet<Integer> primeNumbers = new TreeSet<>();
		for (String number : numbers) {
			if (number.equals("")) {
				continue;
			}
			int n = Integer.parseInt(number);
			if (isPrime(n)) {
				primeNumbers.add(n);
			}
		}
		if (primeNumbers.size() < 3) {
			System.out.println("No");
		} else {
			int sum = 0;
			for (int i = 0; i < 3; i++) {
				sum += primeNumbers.last();
				primeNumbers.remove(primeNumbers.last());
			}
			System.out.println(sum);
		}
	}
	
	
	
	static boolean isPrime (Integer n) {
		if (n < 2) {
			return false;
		} 
		for (int i = 2; i <= Math.sqrt(n); i++) {
			if (n % i == 0) {
				return false;
			}
		}
		return true;
	}

}
