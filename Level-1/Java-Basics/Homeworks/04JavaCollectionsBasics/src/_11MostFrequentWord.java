import java.util.Collections;
import java.util.Scanner;
import java.util.TreeMap;


public class _11MostFrequentWord {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String[] input = scan.nextLine().toLowerCase().split("[\\W]+");
		TreeMap<String, Integer> wordsCount = new TreeMap<>();
		for (String word : input) {
			Integer count = wordsCount.get(word);
			if (count == null) {
				count = 0;
			}
			wordsCount.put(word, count+1);
		}
		int maxValue=(Collections.max(wordsCount.values()));
		for (String word : wordsCount.keySet()) {
			if (wordsCount.get(word) == maxValue) {
				System.out.printf("%s -> %d times\n", word, wordsCount.get(word));
			}
		}
	}

}
