package purchase;

import java.util.Date;

import javax.management.InvalidAttributeValueException;

import products.FoodProduct;
import products.Product;
import customers.Customer;
import enums.AgeRestriction;
import exceptions.BuyersNotHaveEnoughMoneyException;
import exceptions.NotHavePermissionToPurchaseException;
import exceptions.ProductExpiredException;
import exceptions.ProductOutOfStockException;

public final class PurchaseManager {
	public static void processPurchase(Product product, Customer customer) 
			throws ProductOutOfStockException, ProductExpiredException,
			BuyersNotHaveEnoughMoneyException, NotHavePermissionToPurchaseException,
			InvalidAttributeValueException {
		if(product.getQuantity() == 0) {
			throw new ProductOutOfStockException();
		}
		if(product instanceof FoodProduct) {
			if(((FoodProduct) product).getExpirationDate() != null) {
				Date currentDate = new Date();
				if(((FoodProduct) product).getExpirationDate().before(currentDate)) {
					throw new ProductExpiredException();
				}
			}
		}
		if(product.getPrice() > customer.getBalance()) {
			throw new BuyersNotHaveEnoughMoneyException();
		}
		if(product.getAgeRestriction().equals(AgeRestriction.Adult) && customer.getAge() < 18) {
			throw new NotHavePermissionToPurchaseException();
		}
		if(product.getAgeRestriction().equals(AgeRestriction.Teenager) && customer.getAge() < 16) {
			throw new NotHavePermissionToPurchaseException();
		}
		
		product.setQuantity(product.getQuantity() - 1);		
		customer.setBalance(customer.getBalance() - product.getPrice());
	}
}
