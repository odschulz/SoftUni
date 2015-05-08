package shop.exceptions;

public class ProductExpiredException extends IllegalArgumentException {
	
	public ProductExpiredException(String message) {
        super(message);
    }
}
