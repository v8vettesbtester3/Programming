package ex01;

import java.util.Scanner;

public class P05 {
	/*
	 * Java 01, Exercise 05
	 * 
	 * Write a Java program that inputs from the user a number of minutes.  
	 * It then calculates what this is in terms of days, hours and minutes.  
	 * For example 2000 minutes = 1 day, 9 hours and 20 minutes.
	 * 
	 * J. M. Hinckley
	 * 2024
	 */

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Enter a number of minutes: ");
		int totalMinutes = sc.nextInt();
		
		int minutes = totalMinutes;		// working value, to be modified
		
		int days = minutes / (60 * 24);	// 60 * 24 minutes / day
		minutes = minutes % (60 * 24);	// # minutes beyond whole # days
		
		int hours = minutes / 60;		// 60 minutes / hour
		minutes = minutes % 60;			// # minutes beyond whole # hours
		
		
		System.out.println(totalMinutes+" minutes = "+days+" days, "
				+hours+" hours and "+minutes+" minutes.");
		
	}

}
