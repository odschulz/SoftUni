package shop.product;

import shop.AgeRestriction;

public class Appliance extends ElectronicsProduct {
	
	private static final int APPLIANCE_GUARANTEE_PERIOD = 6;

	public Appliance(String name, double price, int quantity,
			AgeRestriction ageRestriction, int guaranteePeriod) {
		super(name, price, quantity, ageRestriction, APPLIANCE_GUARANTEE_PERIOD);
	}

	@Override
	public double getPrice() {
		if (this.getQuantity() < 50) {
			return super.getPrice() * 1.05;
		}
		
		return super.getPrice();
	}
	
	@Override
	public String toString() {
		return super.toString();
	}

}
