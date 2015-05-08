import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.Collections;


public class _09ListOfProducts {
	public static void main(String[] args) {
		ArrayList<Product> items = new ArrayList<Product>();
		try(
			BufferedReader reader = new BufferedReader(new FileReader("src/input2.txt"));
			BufferedWriter writer = new BufferedWriter(new FileWriter("src/output.txt"));
		) {
			String line = null;
			while ((line = reader.readLine()) != null) {
				String[] splittedLine = line.split(" ");
                items.add(new Product(splittedLine[0], Double.parseDouble(splittedLine[1])));
			}
			Collections.sort(items);
			for (Product product : items) {
				writer.write(product.toString());
				writer.newLine();
			}
		} catch (Exception ex){
			System.err.println("Error " + ex.getLocalizedMessage());
		}
	}

}
class Product implements Comparable<Product> {
	private String name;
	private double price;
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public double getPrice() {
		return price;
	}
	public void setPrice(double price) {
		this.price = price;
	}
	public Product(String name, double price) {
		super();
		this.name = name;
		this.price = price;
	}
	@Override
	public int compareTo(Product item) {
		if (this.price > item.getPrice()) {
			return 1;
		}
		else if (this.price < item.getPrice()) {
			return -1;
		}
		else {
			return 0;
		}
	}
	@Override
	public String toString() {
		DecimalFormat formatter = new DecimalFormat("#0.00");
		return (formatter.format(this.price) + " " + this.name);
	}
}
