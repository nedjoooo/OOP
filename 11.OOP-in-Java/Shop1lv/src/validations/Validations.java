package validations;

import java.util.Date;

public final class Validations {
	public static boolean nameValidation(String name) {
		if(name == null || name == "") {
			return false;
		}
		return true;
	}
	
	public static boolean priceValidation(double price) {
		if(price <= 0) {
			return false;
		}
		return true;
	}
	
	public static boolean balanceValidation(double balance) {
		if(balance < 0) {
			return false;
		}
		return true;
	}
	
	public static boolean ageValidation(int age) {
		if(age <= 0) {
			return false;
		}
		return true;
	}
	
	public static boolean quantityValidation(int quantity) {
		if(quantity <= 0) {
			return false;
		}
		return true;
	}
	
	public static boolean expireDateValidation(Date expireDate) {
		Date currentDate = new Date();
		if(expireDate.before(currentDate)) {
			return false;
		}
		return true;
	}
	
	public static boolean guaranteePerioadValidation(int guaranteePeriod) {
		if(guaranteePeriod < 0) {
			return false;
		}
		return true;
	}
}
