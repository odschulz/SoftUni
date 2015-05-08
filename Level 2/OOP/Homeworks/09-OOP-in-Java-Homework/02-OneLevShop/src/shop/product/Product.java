package shop.product;

import shop.AgeRestriction;
import shop.ValidationMethods;
import shop.interfaces.Buyable;

public abstract class Product implements Buyable { 
	
	private String name;
	private double price;
	private int quantity;
	private AgeRestriction ageRestriction;
	
	public Product(String name, double price, int quantity,
			AgeRestriction ageRestriction) {
		this.setName(name);
		this.setPrice(price);
		this.setQuantity(quantity);
		this.setAgeRestriction(ageRestriction);
	}

	public String getName() {
		return this.name;
	}

	public void setName(String name) {
		ValidationMethods.checkIfStringIsNullOrEmpty("Product Name", name);
		this.name = name;
	}

	@Override
	public double getPrice() {
		return this.price;
	}

	public void setPrice(double price) {
		ValidationMethods.checkIfNumberIsZeroOrNegative("Product Price", price);
		this.price = price;
	}

	public int getQuantity() {
		return this.quantity;
	}

	public void setQuantity(int quantity) {
		ValidationMethods.checkIfNumberIsNegative("Product Quantity", quantity);
		this.quantity = quantity;
	}

	public AgeRestriction getAgeRestriction() {
		return this.ageRestriction;
	}

	public void setAgeRestriction(AgeRestriction ageRestriction) {
		this.ageRestriction = ageRestriction;
	}
	
	@Override
    public String toString() {
        return String.format("%s - price: %.2f, quantity: %d", this.getName(), this.getPrice(), this.getQuantity());
    }
}
