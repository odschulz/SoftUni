package shop.product;

import shop.AgeRestriction;
import shop.ValidationMethods;

public abstract class ElectronicsProduct extends Product {
	
	private int guaranteePeriod;

	public ElectronicsProduct(String name, double price, int quantity,
			AgeRestriction ageRestriction, int guaranteePeriod) {
		super(name, price, quantity, ageRestriction);
		this.setGuaranteePeriod(guaranteePeriod);
	}

	public int getGuaranteePeriod() {
		return this.guaranteePeriod;
	}

	public void setGuaranteePeriod(int guaranteePeriod) {
		ValidationMethods.checkIfNumberIsNegative("Guarantee Period", guaranteePeriod);
		this.guaranteePeriod = guaranteePeriod;
	}
	
	@Override
	public String toString() {
		return super.toString() + String.format(", Guarantee Period: %d months", this.getGuaranteePeriod());
	}

}
