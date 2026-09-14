/*
 Java 05, Ex 01
 
Method overloading. 
Write a Java program which has a main method and three overloaded computeBill() methods.  
These methods pertain to billing for the purchase of a photo book.

a. When computeBill() receives a single parameter, it represents the price of one photo book ordered.  
   Add 8% tax and return the total amount due.
   
b. When computeBill() receives two parameters, they represent the price of a photo book and the quantity ordered.  
   Multiply the two values, then add 8% tax and return the total amount due.
   
c. When computeBill() receives three parameters, they represent the price of a photo book, 
   the quantity ordered and a coupon value.  Multiply the first two values, subtract the coupon value, 
   then add 8% tax and return the total amount due.

In your main method, test all three overloaded computeBill() methods, printing the values of the 
input parameters and the returned calculated total amount due.
 
J. M. Hinckley
2024 
 */

package ex05;

import java.util.Scanner;

public class P01 {

	public static void main(String[] args) {
		Scanner sc = new Scanner (System.in);
		
		System.out.print("Price of one photo book: ");
		double priceOfOne = sc.nextDouble();
		
		System.out.print("Value of the coupon: ");
		double couponValue = sc.nextDouble();
		
		System.out.println("\n\nTotal bill for one book, including tax: " 
				+ String.format("$%.2f",computeBill(priceOfOne)));
		

		System.out.print("\nEnter quantity for the second order: ");
		int quantity = sc.nextInt();
		System.out.println("Total bill for " + quantity + " books, including tax: "
				+ String.format("$%.2f",computeBill(priceOfOne, quantity)));
		
	
		System.out.print("\nEnter quantity for the third order: ");
		quantity = sc.nextInt();
		System.out.println("Total bill for " + quantity + " books, with a discount of "
				+ String.format("$%.2f",couponValue) + " including tax: " 
				+ String.format("$%.2f",computeBill(priceOfOne, quantity, couponValue)));
		
		sc.close();
	}
	
	public static double computeBill(double priceOfOne) {
		double totalBill = 0;
		
		double tax = 0.08 * priceOfOne;
		totalBill = priceOfOne + tax;
		
		return totalBill;
	}

	public static double computeBill(double priceOfOne, int quantity) {
		double totalBill = 0;
		
		double totalPurchases = priceOfOne * quantity;
		double tax = 0.08 * totalPurchases;
		totalBill = totalPurchases + tax;
		
		return totalBill;
	}

	public static double computeBill(double priceOfOne, int quantity, double couponValue) {
		double totalBill = 0;
		
		double totalPurchases = priceOfOne * quantity - couponValue;
		double tax = 0.08 * totalPurchases;
		totalBill = totalPurchases + tax;
		
		return totalBill;
	}

}
