/*
 LocalDate class.  
 Refer to the LocalDate API documentation at 
https://docs.oracle.com/en/java/javase/21/docs/api/java.base/java/time/LocalDate.html
and write a Java program that uses the LocalDate class to represent and calculate some dates:

a. Use the LocalDate.now() method to calculate the current date.  
   Print this out.

b. Use the LocalDate.of() method to create a LocalDate object for your next birthday. 
   Print this out.

c. Use the LocalDate.until() method to calculate the period of time until your next birthday.  
   For the Temporal Unit, use ChronoUnit.DAYS.  
   You will need to import java.time.temporal.ChronoUnit to do this.  
   Print out the number of days.

J. M. Hinckley
2024
 */
package ex05;

import java.time.*;
import java.time.temporal.ChronoUnit;

public class P02 {

	public static void main(String[] args) {
		LocalDate current = LocalDate.now();	// current date/time
		System.out.println("Current date: " + current);

		LocalDate nextBD = LocalDate.of(2025, 1, 1);
		System.out.println("Next birthday will be on: " + nextBD);
		
		long days = current.until(nextBD, ChronoUnit.DAYS);
		System.out.println("Number of days until next birthday: " + days);
	}

}
