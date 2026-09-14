/*
 Java 05, Ex 04
 
Using composition.  
Write a Java program that consists of a main() method and 
three other Java classes (4 Java source files in total).  

The first class is named Person and has two String fields 
for a first name and a last name, 
and a LocalDate field for the person’s birthdate.

The second class is named Couple and has two Person fields.

The third class is named Wedding and has a LocalDate field for the date of the wedding,
a Couple field and a String field for the location of the wedding.

Provide constructors for each class that accept parameters for 
each of its fields and provide get methods for each field.

In the main() method, create two Wedding objects and then pass 
each Wedding object to a method that displays all of the details.

J. M. Hinckley
2024
 */

package ex05;

import java.time.*;

public class P04 {

	public static void main(String[] args) {
		LocalDate date1 = LocalDate.of(1996, 12, 14);
		Person pA1 = new Person("Kimberly", "Hanson", date1);
		LocalDate date2 = LocalDate.of(1994, 3, 8);
		Person pB1 = new Person("Mark", "Ziller", date2);
		LocalDate date3 = LocalDate.of(2001, 4, 17);
		Person pA2 = new Person("Janna", "Howard", date3);
		LocalDate date4 = LocalDate.of(2002, 2, 14);
		Person pB2 = new Person("Julius", "Nemo", date4);
		
		Couple couple1 = new Couple(pA1, pB1);
		Couple couple2 = new Couple(pA2, pB2);
		
		LocalDate date5 = LocalDate.of(2026, 6, 18);
		Wedding wedding1 = new Wedding(date5, couple1, "Mayfair Country Club");
		LocalDate date6 = LocalDate.of(2026, 6, 25);
		Wedding wedding2 = new Wedding(date6, couple2, "Oceanview Park");
		
		displayWeddingDetails(wedding1);
		displayWeddingDetails(wedding2);
	}

	public static void displayWeddingDetails(Wedding w) {
		Couple couple = w.getWeddingCouple();
		LocalDate weddingDate = w.getWeddingDate();
		String location = w.getWeddingLocation();
		Person partnerLeft = couple.getPartnerLeft();
		Person partnerRight = couple.getPartnerRight();
		String firstLeft = partnerLeft.getFirstName();
		String lastLeft = partnerLeft.getLastName();
		LocalDate leftBDate = partnerLeft.getBirthdate();
		String firstRight = partnerRight.getFirstName();
		String lastRight = partnerRight.getLastName();
		LocalDate rightBDate = partnerRight.getBirthdate();

		System.out.println("\n" + lastLeft + "/" + lastRight + " Wedding");

		System.out.println("Date: " + weddingDate + "   Location: " + location);

		System.out.println("Partner A: " + firstLeft + " " + lastLeft + " " + leftBDate);

		System.out.println("Partner B: " + firstRight + " " + lastRight + " " + rightBDate);
	}

}
