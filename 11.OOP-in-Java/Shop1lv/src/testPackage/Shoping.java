package testPackage;

import interfaces.Expirable;

import java.text.ParseException;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

import javax.management.InvalidAttributeValueException;

import customers.Customer;
import enums.AgeRestriction;
import exceptions.BuyersNotHaveEnoughMoneyException;
import exceptions.NotHavePermissionToPurchaseException;
import exceptions.ProductExpiredException;
import exceptions.ProductOutOfStockException;
import products.Appliance;
import products.Computer;
import products.ElectonicsProduct;
import products.FoodProduct;
import products.Product;
import purchase.PurchaseManager;

public class Shoping {

	public static void main(String[] args) throws InvalidAttributeValueException, ParseException {
		Product foodProduct = new FoodProduct("Cheese", 8.99,
				100, AgeRestriction.None, "24-2-2015");		
		System.out.println(foodProduct);
		
		FoodProduct cigars = new FoodProduct("420 Blaze it fgt", 6.90,
				1400, AgeRestriction.Adult, "31-12-2020");
		System.out.println(cigars);
		
		FoodProduct ballantines = new FoodProduct("Wiskey Ballantines", 22.90,
				800, AgeRestriction.Adult, "31-12-2030");
		System.out.println(cigars);
		
		Product electronicProductTV = new ElectonicsProduct("Sony TV HS42D FULLHD", 1499.99, 5, 
				AgeRestriction.None, 24);
		System.out.println(electronicProductTV);
		
		Product electronicProductHDMIKable = new ElectonicsProduct("HDMI Kable", 8.49, 1300, 
				AgeRestriction.None);
		System.out.println(electronicProductHDMIKable);
		
		Product hpComp = new Computer("HP", 599.00, 1050, AgeRestriction.None);
		System.out.println(hpComp);
		
		Product appliance = new Appliance("TV Table", 159.99, 45, AgeRestriction.None);
		System.out.println(appliance);
		
		Customer baiIvan = new Customer("Bai Ivan", 56, 700.00);
		System.out.println(baiIvan);
		
		Customer pecata = new Customer("Pecata", 17, 30.00);
		System.out.println(pecata);
		System.out.println();
		
		try {
			System.out.println(pecata.getName() + " will be purchase " + cigars.getName());
			PurchaseManager.processPurchase(cigars, pecata);
			System.out.println("This purchase have successfully!");
		} catch (BuyersNotHaveEnoughMoneyException e){
			System.err.println(pecata.getName() + " do not have enough money to buy this product!");
		} catch (ProductOutOfStockException e) {
			System.err.println("This product out of stock!");
		} catch (ProductExpiredException e) {
			System.err.println("This product is expired!");
		} catch (NotHavePermissionToPurchaseException e) {
			System.err.println(pecata.getName() + " are too young to buy this product!");
		}
		
		try {
			System.out.println(baiIvan.getName() + " will be purchase " + electronicProductTV.getName());
			PurchaseManager.processPurchase(electronicProductTV, baiIvan);
			System.out.println("This purchase have successfully!");
		} catch (BuyersNotHaveEnoughMoneyException e){
			System.err.println(baiIvan.getName() + " do not have enough money to buy this product!");
		} catch (ProductOutOfStockException e) {
			System.err.println("This product out of stock!");
		} catch (ProductExpiredException e) {
			System.err.println("This product is expired!");
		} catch (NotHavePermissionToPurchaseException e) {
			System.err.println(baiIvan.getName() + " are too young to buy this product!");
		}
		
		List<Product> productList = new ArrayList<Product>();
		productList.add(ballantines);
		productList.add(foodProduct);
		productList.add(cigars);
		productList.add(electronicProductTV);
		productList.add(electronicProductHDMIKable);
		productList.add(hpComp);
		productList.add(appliance);		
		
		List<Expirable> expirableProductsList = productList
				.stream()
				.filter(item -> item instanceof Expirable)
				.map(item -> (Expirable)item)
				.collect(Collectors.toList());
		expirableProductsList
			.sort((item1, item2) -> item1.getExpirationDate().compareTo(item2.getExpirationDate()));
		
		Expirable expirableProduct = expirableProductsList
				.get(0);
		
		System.out.println();
		System.out.println("Fisrt expirable product is:");
		System.out.println(expirableProduct);
		System.out.println();
		
		List<Product> haveAdultAgeRestriction = productList
				.stream()
				.filter(item -> item.getAgeRestriction().equals(AgeRestriction.Adult))
				.collect(Collectors.toList());
		haveAdultAgeRestriction
			.sort((item1, item2) -> Double.compare(item1.getPrice(), item2.getPrice()));
		
		System.out.println("Product adult age restriction sorted by price in ascending order");
		haveAdultAgeRestriction.forEach(item -> System.out.println(item));
	}

}
