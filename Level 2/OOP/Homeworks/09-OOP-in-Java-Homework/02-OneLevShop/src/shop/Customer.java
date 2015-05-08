package shop;

public class Customer {
	private String name;
	private int age;
	private double balance;
	
	public Customer(String name, int age, double balance) {
		this.setName(name);
		this.setAge(age);
		this.setBalance(balance);
	}
	
	public String getName() {
		return this.name;
	}

	private void setName(String name) {
		ValidationMethods.checkIfStringIsNullOrEmpty("Customer Name", name);
		this.name = name;
	}

	public int getAge() {
		return this.age;
	}

	public void setAge(int age) {
		ValidationMethods.checkIfNumberIsZeroOrNegative("Customer Age", age);
		this.age = age;
	}

	public double getBalance() {
		return this.balance;
	}

	public void setBalance(double balance) {
		ValidationMethods.checkIfNumberIsNegative("Customer Balance", balance);
		this.balance = balance;
	}

}
