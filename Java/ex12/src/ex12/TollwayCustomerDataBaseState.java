package ex12;

import java.util.*;
import java.text.NumberFormat;
import java.io.*;

public class TollwayCustomerDataBaseState {

	public static void main(String args[]) {
		BufferedReader in = getReader("Names.txt");
		// Change from abstract List<> to implementation ArrayList<> on LHS
		ArrayList<Customer> customers = new ArrayList<Customer>(); // contains the customer objects
		Customer cust = readCustomer(in);
		customers.add(cust);
		while (cust != null) {
			cust = readCustomer(in);
			if (cust != null)
				customers.add(cust);
		}
		System.out.println(">>>>>>>>>>>>>> There were " + customers.size() + " created. <<<<<<<<<\n");
		for (Customer c : customers) {
			System.out.println(c.getInfo());
		}
	}

	/**
	 * Reads the information from the file and breaks it into each of the
	 * objects that go into the Customer object.
     * 
	 * @param in
	 * @return Customer
	 * 
	 */
	private static Customer readCustomer(BufferedReader in) {
		// Name Class plus Fields
		Name name;
		String firstN;
		String lastN;
		// CarInfo Class plus Fields
		CarInfo carinfo;
		String make;
		String model;
		String plates;

		// Payment Class plus Fields
		Payment payment;
		double deposit;
		String creditcard;
		String line = "";
		String[] data;

		// Catches errors in the read
		try {
			line = in.readLine();
		} catch (IOException e) {
			System.out.println("I/O Error");
			System.exit(0);
		}

		// ends the read once it gets to the end
		if (line == null)
			return null;
		else {
			data = line.split(",");
			firstN = data[0];
			lastN = data[1];
			make = data[2];
			model = data[3];
			plates = data[4];
			deposit = Double.parseDouble(data[5]);
			creditcard = data[6];

			// construct the objects to be placed in the Customer object
			name = new Name(firstN, lastN);
			carinfo = new CarInfo(make, model, plates);
			payment = new Payment(deposit, creditcard);
			return new Customer(name, carinfo, payment);
		}
	}

	private static BufferedReader getReader(String name) {
		BufferedReader in = null;
		try {
			File file = new File(name);
			in = new BufferedReader(new FileReader(file));
		} catch (FileNotFoundException e) {
			System.out.println("The file doesn't exist.");
			System.exit(0);
		}
		return in;
	}

}

//////Customer Attributes: Name, CarInfo, Payment
class Customer {
	private Name name;
	private CarInfo carinfo;
	private Payment pay;

	public Customer(Name n, CarInfo c, Payment p) {
		name = n;
		carinfo = c;
		pay = p;
	}

	public String getInfo() {
		return name.getInfo() + "\n" + carinfo.getInfo() + "\n" + pay.getInfo() + "\n";
	}

}

//////Name Attributes: first name, last name
class Name {
	private String last_Name;
	private String first_Name;

	public Name(String fn, String ln) {
		last_Name = ln;
		first_Name = fn;
	}

	public String getInfo() {
		return "Name: " + first_Name + " " + last_Name;
	}

}

//////CarInfo Attributes: make, model, license_plates
class CarInfo {
	private String make;
	private String model;
	private String license_plates;

	public CarInfo(String ma, String mo, String lp) {
		make = ma;
		model = mo;
		license_plates = lp;
	}

	public String getInfo() {
		return "Car Information: " + make + " " + model + " " + license_plates;
	}

}

//////Payment Attributes: deposit, credit_card 
class Payment {
	private double deposit;
	private String credit_card;

	public Payment(double d, String cc) {
		deposit = d;
		credit_card = cc;
	}

	public String getInfo() {
		return String.format("Payment: $%.2f %s", deposit, credit_card);
	}

}
