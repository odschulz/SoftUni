package shop.product;

import shop.AgeRestriction;

public class Computer extends ElectronicsProduct {
	
	private static final int COMPUTER_GUARANTEE_PERIOD = 24;

	public Computer(String name, double price, int quantity,
			AgeRestriction ageRestriction, int guaranteePeriod) {
		super(name, price, quantity, ageRestriction, COMPUTER_GUARANTEE_PERIOD);
	}

	@Override
	public double getPrice() {
		if (this.getQuantity() > 1000) {
			return super.getPrice() * 0.95;
		}
		
		return super.getPrice();
	}
	
	@Override
	public String toString() {
		return super.toString();
	}
}
