// From BPA RLC 2021

package ex14;

import java.util.ArrayList;
import java.util.Scanner;

public class StockDriver {

	public static void main(String[] args) {
		// Declare Scanner and ArrayList<Stocks>
		Scanner sc = new Scanner(System.in);
		int quantity = 0;
		ArrayList<Stocks> stocks = new ArrayList<Stocks>();
		try {
			// Do-while forces user to enter in 1-10 as the value of stocks
			do {
				System.out.println("How many stocks do you want to create?");
				quantity = sc.nextInt();
				sc.nextLine();
				if (quantity < 0 || quantity > 10) {
					System.out.println("\nYou entered a value too low or too high.  Try again please.");
				}
			} while (quantity < 0 || quantity > 10);
			
			System.out.println("\nYou entered: "+quantity);
			System.out.println("\nYou will now enter in the company symbol, name and their share quantity."
					+ "\nThe price will be randomly generated.");
			int i = 0;
			
			// Data entry for Symbol, Name and Shares through user input.
			// Block also creates Stock objects based upon entered values.
			while (i < quantity) {
				System.out.println("\nPlease enter the three character symbol:");
				String tempSymbol = sc.nextLine();
				System.out.println("\nPlease enter the company name:");
				String tempName = sc.nextLine();
				System.out.println("\nPlease enter the total shares:");
				int tempShares = sc.nextInt();
				sc.nextLine();
				Stocks tempEntry = new Stocks(tempSymbol, tempName, tempShares);
				stocks.add(tempEntry);
				i++;
			}
			
			// Print the entire ArrayList of Stocks
			System.out.println("\nList below is your current portfolio:");
			for (Stocks s : stocks) {
				System.out.println(s);
			}
			
			sc.close();
		}
		catch (Exception e) {
			System.out.println("\nThat is an improper value.  The program has been stopped.");
		}
		
	}
	

}

class Stocks {
	private String symbol;
	private String name;
	private double price;
	private int shares;
	private int min = 1;
	private int max = 200;
	
	public Stocks() {
		super();
		symbol = "";
		name = "";
		price = setPrice();
		shares = 0;
	}

	public Stocks(String symbol, String name, int shares) {
		super();
		this.symbol = symbol;
		this.name = name;
		this.shares = shares;
		price = setPrice();
	}

	public double setPrice() {
		price = (Math.random()*((max-min)+1)+min);
		price = Math.floor(price*100);
		price /= 100;
		return price;
	}
	
	public double getValue() {
		double temp = Math.floor(price*shares*100);
		temp /= 100;
		return temp;
	}
	
	@Override
	public String toString() {
		return " Symbol: " + symbol + " | " + " Company Name: " + name + " | " + " Price: "
				+ String.format("$%, .2f", price) + " | " + " Total Shares: " + shares + " | " + " Total Value: "
				+ String.format("$%, .2f", this.getValue());
	}	
	
}
