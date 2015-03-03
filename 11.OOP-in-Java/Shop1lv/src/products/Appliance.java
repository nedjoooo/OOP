package products;

import javax.management.InvalidAttributeValueException;

import enums.AgeRestriction;

public class Appliance extends ElectonicsProduct {

	public Appliance(String name, double price, int quantity,
			AgeRestriction ageRestriction)
			throws InvalidAttributeValueException {
		super(name, price, quantity, ageRestriction, 6);
	}

	@Override
	public double getPrice() {
		if(this.getQuantity() < 50) {
			return (super.getPrice() / 100) * 105;
		}
		return super.getPrice();
	}

	
}
