import java.io.BufferedReader;
import java.io.FileReader;


public class _08SumNumbersFromATextFile {
	public static void main(String[] args) {
		try(
			BufferedReader reader = new BufferedReader(new FileReader("src/input1.txt"));
		) {
			String line = null;
			int sum = 0;
			while ((line = reader.readLine()) != null) {
				sum += Integer.parseInt(line);
			}
			System.out.println(sum);
		} catch (Exception ex) {
			System.err.println("Error " + ex.getLocalizedMessage());
		}
	}

}
