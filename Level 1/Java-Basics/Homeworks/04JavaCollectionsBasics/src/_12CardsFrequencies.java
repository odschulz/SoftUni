import java.util.LinkedHashMap;
import java.util.Scanner;


public class _12CardsFrequencies {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String[] input = scan.nextLine().split("[\\W]+");
		LinkedHashMap<String, Integer> cardsCount = new LinkedHashMap<>();
		for (String card : input) {
			Integer count = cardsCount.get(card);
			if (count == null) {
				count = 0;
			}
			cardsCount.put(card, count+1);
		}
		for (String card : cardsCount.keySet()) {
			double frequency = (cardsCount.get(card)/(double)input.length)*100;
			System.out.printf("%s -> %.2f%%\n", card, frequency);
			//System.out.println(frequency);
		}
	}

}
