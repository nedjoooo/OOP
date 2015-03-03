package customers;

import javax.management.InvalidAttributeValueException;

import validations.Validations;

public class Customer {
	private String name;
	private int age;
	private double balance;
	
	public Customer(String name, int age, double balance) throws InvalidAttributeValueException {
		setName(name);
		setAge(age);
		setBalance(balance);
	}

	public String getName() {
		return name;
	}
	
	public void setName(String name) throws InvalidAttributeValueException {
		if(!Validations.nameValidation(name)) {
			throw new InvalidAttributeValueException("Customer name cannot be empty!");
		}
		this.name = name;
	}
	
	public int getAge() {
		return age;
	}
	
	public void setAge(int age) throws InvalidAttributeValueException {
		if(!Validations.ageValidation(age)) {
			throw new InvalidAttributeValueException("Customer age cannot be negative or zero!");
		}
		this.age = age;
	}
	
	public double getBalance() {
		return balance;
	}
	
	public void setBalance(double balance) throws InvalidAttributeValueException {
		if(!Validations.balanceValidation(balance)) {
			throw new InvalidAttributeValueException("Customer age cannot be negative or zero!");
		}
		this.balance = balance;
	}

	@Override
	public String toString() {
		return String.format("Customer( Name = %s, Age = %d, Balance = %.2f",
				this.getName(), this.getAge(), this.getBalance());
	}
	
	
}
