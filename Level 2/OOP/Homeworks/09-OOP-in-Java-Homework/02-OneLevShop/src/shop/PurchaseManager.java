package shop;

import java.util.Date;

import shop.exceptions.IllegalPurchaseException;
import shop.exceptions.InsufficientBalanceException;
import shop.exceptions.OutOfStockException;
import shop.exceptions.ProductExpiredException;
import shop.interfaces.Expirable;
import shop.product.Product;

public class PurchaseManager {
	public static void processPurchase(Customer customer, Product product, int productAmount) {
		checkIfInStock(product, productAmount);
		checkIfProductExpired(product);
		checkCustomerBalance(customer, product, productAmount);
		checkForAgeRestriction(customer, product);
		
		int newQuantity = product.getQuantity() - productAmount;
		double newBalance = customer.getBalance() - (product.getPrice() * productAmount);
		
		product.setQuantity(newQuantity);
		customer.setBalance(newBalance);
	}
	
	private static void checkIfInStock(Product product, int productAmount) {
		if (product.getQuantity() - productAmount < 0) {
			throw new OutOfStockException(
					String.format("Purchace cannot be processed. Not enough %s in stock", product.getName()));
		}
	}
	
	private static void checkIfProductExpired(Product product) {
		if (product instanceof Expirable) {
			Date now = new Date();
			Date expirationDate = ((Expirable) product).getExpirationDate();
			if (expirationDate.before(now)) {
				throw new ProductExpiredException(
						String.format("Purchace cannot be processed. %s has expired.", product.getName()));
			}
		}
	}
	
	private static void checkCustomerBalance(Customer customer, Product product, int productAmount) {
		double customerBalance = customer.getBalance();
		double purchacePrice = product.getPrice() * productAmount;
		if (customerBalance - purchacePrice < 0) {
			throw new InsufficientBalanceException(
					String.format(
							"Purchace cannot be processed. Customer %s has insufficient balance.",
							customer.getName()));
		}
	}
	
	private static void checkForAgeRestriction(Customer customer, Product product) {
		if ((product.getAgeRestriction() == AgeRestriction.TEENAGER && customer.getAge() < 13)
				|| (product.getAgeRestriction() == AgeRestriction.ADULT && customer.getAge() < 18)) {
			throw new IllegalPurchaseException(
					String.format("Purchace cannot be processed. Customer %s is underaged.", 
							customer.getName()));
		}
	}
}
