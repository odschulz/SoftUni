package shop.exceptions;

public class OutOfStockException extends IllegalArgumentException {
	
	public OutOfStockException(String message) {
        super(message);
    }
}
