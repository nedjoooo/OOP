package products;

import interfaces.Expirable;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

import javax.management.InvalidAttributeValueException;

import enums.AgeRestriction;
import validations.Validations;

public class FoodProduct extends Product implements Expirable {
	private Date expireDate = null;
	
	public FoodProduct(String name, double price, int quantity,
			AgeRestriction ageRestriction)
			throws InvalidAttributeValueException {
		super(name, price, quantity, ageRestriction);
	}

	public FoodProduct(String name, double price, int quantity,
			AgeRestriction ageRestriction, String strExpireDate)
			throws InvalidAttributeValueException, ParseException {
		super(name, price, quantity, ageRestriction);
		setExpirationDate(strExpireDate);
	}
	
	public Date getExpirationDate() {		
		return expireDate;
	}

	public void setExpirationDate(String strExpireDate) throws InvalidAttributeValueException, ParseException {
		if(!strExpireDate.isEmpty()) {
			DateFormat df = new SimpleDateFormat("d-M-yyyy");
			Date expireDate = df.parse(strExpireDate);
			if(!Validations.expireDateValidation(expireDate)) {
				throw new InvalidAttributeValueException("Expire date cannot be before current date!");
			}
			this.expireDate = expireDate;
		} else {
			this.expireDate = null;
		}		
	}

	@Override
	public double getPrice() {
		if(this.expireDate != null) {
			int daysToExpiritionDate = daysBetween(new Date(), this.expireDate);
			if(daysToExpiritionDate <= 15) {
				return (super.getPrice() / 100) * 70;
			}
		}		
		return super.getPrice();
	}

	@Override
	public String toString() {
		StringBuilder result = new StringBuilder();
		result.append(super.toString());
		if(this.expireDate == null) {
			result.append(")");		
		} else {
			result.append(String.format(", Expire date = %s)", this.getExpirationDate()));
		}		
		return result.toString();
	}
	
	private int daysBetween(Date d1, Date d2){
        return (int)( (d2.getTime() - d1.getTime()) / (1000 * 60 * 60 * 24)) + 1;
	}
	
}
