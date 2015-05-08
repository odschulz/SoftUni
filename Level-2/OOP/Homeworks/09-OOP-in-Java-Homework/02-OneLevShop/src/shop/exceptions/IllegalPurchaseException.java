package shop.exceptions;

public class IllegalPurchaseException extends IllegalArgumentException {
	
	public IllegalPurchaseException(String message) {
        super(message);
    }
}
