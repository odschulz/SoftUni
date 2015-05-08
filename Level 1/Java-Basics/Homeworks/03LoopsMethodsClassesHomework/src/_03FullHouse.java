
public class _03FullHouse {
	public static void main(String[] args) {
		String[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J",
				"Q", "K", "A" };
		char[] suits = {'♣', '♦', '♥', '♠'};
		int counter = 0;
		for (int i = 0; i < ranks.length; i++) {
			for (int j = 0; j < ranks.length; j++) {
				for (int k = 0; k < suits.length; k++) {
					for (int l = k+1; l < suits.length; l++) {
						for (int m = l+1; m < suits.length; m++) {
							for (int n = 0; n < suits.length; n++) {
								for (int p = n+1; p < suits.length; p++) {
									if (i != j) {
										System.out.printf("(%s%c %s%c %s%c %s%c %s%c)...", ranks[i], suits[k], ranks[i], suits[l], ranks[i], suits[m], ranks[j], suits[n], ranks[j], suits[p]);
										//can make int j = i +1, remove the if statement, remove counter++ and add the following:
										//System.out.printf("(%s%c %s%c %s%c %s%c %s%c)...", ranks[i], suits[n], ranks[i], suits[p], ranks[j], suits[k], ranks[j], suits[l], ranks[j], suits[m]);
										//counter +=2;
										//seems legit :)
										counter ++;
									}
								}
							}
						}
					}
					
				}
			}
		}
		System.out.println();
		System.out.println(counter);
	}

}
