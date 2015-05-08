package shop;

import java.util.ArrayList;
import java.util.List;

import shop.interfaces.Expirable;
import shop.product.FoodProduct;
import shop.product.Product;

public class TestShop {

	public static void main(String[] args) {
		
		FoodProduct cigars = new FoodProduct(
				"420 BlazeIt", 6.90, 1400, AgeRestriction.ADULT, DateMethods.parseDate("01-01-2018"));
		
		FoodProduct cigarettes = new FoodProduct(
				"Marlboro", 7.90, 1400, AgeRestriction.ADULT, DateMethods.parseDate("01-01-2020"));
		
		FoodProduct cheese = new FoodProduct(
				"Cheese", 11.90, 100, AgeRestriction.NONE, DateMethods.parseDate("24-02-2016"));
		
		FoodProduct wine = new FoodProduct(
				"Wine", 1.90, 1000, AgeRestriction.ADULT, DateMethods.parseDate("24-02-2025"));
		
		FoodProduct salami = new FoodProduct(
				"Salami", 5.90, 200, AgeRestriction.NONE, DateMethods.parseDate("01-01-2016"));
		
		Customer pecata = new Customer("Pecata", 17, 30.00);
		Customer gopeto = new Customer("Gopeto", 18, 0.44);
		Customer pesho = new Customer("Pesho", 30, 1000.00);
		
		
		List<Product> products = new ArrayList<Product>();
		products.add(cigars);
		products.add(cigarettes);
		products.add(cheese);
		products.add(wine);
		products.add(salami);
		
		List<Customer> customers = new ArrayList<Customer>();
		customers.add(pecata);
		customers.add(gopeto);
		customers.add(pesho);
		
		try {
			// I added a product amount to the processPurchase method
			PurchaseManager.processPurchase(customers.get(0), products.get(0), 1);

		} catch (IllegalArgumentException e) {
			System.err.println(e.getMessage());
		}
		
		try {
			PurchaseManager.processPurchase(customers.get(1), products.get(0), 1);

		} catch (IllegalArgumentException e) {
			System.err.println(e.getMessage());
		}
		
		Product productWithSoonestExpirationDate = products.stream()
		.filter(p -> p instanceof Expirable)
		.map(p -> (Expirable) p)
		.sorted((p1, p2) -> p1.getExpirationDate().compareTo(p2.getExpirationDate()))
		.map(p -> (Product) p)
		.findFirst()
		.get();
		
		System.out.println("\nProduct with most recent expiration date:\n");
		System.out.println(productWithSoonestExpirationDate);
		
		System.out.println("\nProducts with Adult restriction sorted by price:\n");
		products.stream()
		.filter(p -> p.getAgeRestriction() == AgeRestriction.ADULT)
		.sorted((p1, p2) -> Double.compare(p1.getPrice(), p2.getPrice()))
		.forEach(p -> System.out.println(p));
		
	}

}
