package products;

import javax.management.InvalidAttributeValueException;

import validations.Validations;
import enums.AgeRestriction;

public class ElectonicsProduct extends Product {
	private int guaranteePeriod = 0;

	public ElectonicsProduct(String name, double price, int quantity,
			AgeRestriction ageRestriction)
			throws InvalidAttributeValueException {
		super(name, price, quantity, ageRestriction);
	}

	public ElectonicsProduct(String name, double price, int quantity,
			AgeRestriction ageRestriction, int guaranteePeriod)
			throws InvalidAttributeValueException {
		super(name, price, quantity, ageRestriction);
		setGuaranteePeriod(guaranteePeriod);
	}

	public int getGuaranteePeriod() {
		return this.guaranteePeriod;
	}

	public void setGuaranteePeriod(int guaranteePeriod) throws InvalidAttributeValueException {
		if(!Validations.guaranteePerioadValidation(guaranteePeriod)) {
			throw new InvalidAttributeValueException("Guarantee period cannot be negative!");
		}
		this.guaranteePeriod = guaranteePeriod;
	}

	@Override
	public String toString() {
		StringBuilder result = new StringBuilder();
		result.append(super.toString());
		if(this.guaranteePeriod == 0) {
			result.append(")");		
		} else {
			result.append(String.format(", Guarantee period = %s)", this.getGuaranteePeriod()));
		}		
		return result.toString();
	}
	
	
	
}
