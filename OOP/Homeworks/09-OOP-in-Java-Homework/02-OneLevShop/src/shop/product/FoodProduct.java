package shop.product;

import java.util.Date;
import java.util.concurrent.TimeUnit;

import shop.AgeRestriction;
import shop.ValidationMethods;
import shop.interfaces.Expirable;

public class FoodProduct extends Product implements Expirable {
	
	private Date expirationDate;

	public FoodProduct(String name, double price, int quantity,
			AgeRestriction ageRestriction, Date expirationDate) {
		super(name, price, quantity, ageRestriction);
		this.setExpirationDate(expirationDate);
	}

	@Override
	public Date getExpirationDate() {
		return this.expirationDate;
	}
	
	public void setExpirationDate(Date expirationDate) {
		ValidationMethods.checkIfDateIsValid("Expiration Date", expirationDate);
		this.expirationDate = expirationDate;
	}

	@Override
	public double getPrice() {
		Date now = new Date();
		long expirationInDays = this.getTimeDifference(now, this.getExpirationDate(), TimeUnit.DAYS);
		if (expirationInDays <= 15) {
			return super.getPrice() * 0.7;
		}
		
		return super.getPrice();
	}
	
	protected long getTimeDifference(Date date1, Date date2, TimeUnit timeUnit) {
	    long diffInMilliseconds = date2.getTime() - date1.getTime();
	    return timeUnit.convert(diffInMilliseconds, TimeUnit.MILLISECONDS);
	}

	@Override
	public String toString() {
		return super.toString() + ", Expirationg Date: " + this.getExpirationDate();
	}
}
