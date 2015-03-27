package shop.exceptions;

public class InsufficientBalanceException extends IllegalArgumentException {
	
	public InsufficientBalanceException(String message) {
        super(message);
    }
}
