package products;

import interfaces.Buyable;

import javax.management.InvalidAttributeValueException;

import validations.Validations;
import enums.AgeRestriction;

public abstract class Product implements Buyable {
	private String name;
	private double price;
	private int quantity;
	private AgeRestriction ageRestriction;
	
	public Product(String name, double price, int quantity,
			AgeRestriction ageRestriction) throws InvalidAttributeValueException {
		setName(name);
		setProductPrice(price);
		setQuantity(quantity);
		this.ageRestriction = ageRestriction;
	}

	public String getName() {
		return name;
	}
	
	public void setName(String name) throws InvalidAttributeValueException {
		if(!Validations.nameValidation(name)) {
			throw new InvalidAttributeValueException("Product name cannot be empty!");
		}
		this.name = name;
	}
	
	public double getPrice() {
		return this.price;
	}
	
	public void setProductPrice(Double price) throws InvalidAttributeValueException {
		if(!Validations.priceValidation(price)) {
			throw new InvalidAttributeValueException("Product price cannot be empty, negative or zero!");
		}
		this.price = price;
	}
	
	public int getQuantity() {
		return quantity;
	}
	
	public void setQuantity(int quantity) throws InvalidAttributeValueException {
		if(!Validations.quantityValidation(quantity)) {
			throw new InvalidAttributeValueException("Product qunatity cannot be empty, negative or zero!");
		}
		this.quantity = quantity;
	}
	
	public AgeRestriction getAgeRestriction() {
		return ageRestriction;
	}

	@Override
	public String toString() {
		return String.format("Product(Name = %s, Price = %.2f, Quantity = %d, Age Restriction = %s",
				this.getName(), this.getPrice(), this.getQuantity(), this.ageRestriction);
	}
	
	
}
