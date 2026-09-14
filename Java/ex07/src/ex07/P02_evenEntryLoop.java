/*
 Java 07, Ex 02
 
Using the while-loop. Write a Java program that asks the user to 
type an even number or the sentinel value 999 to stop.  
When the user types an even number, display the message: 
“Correct” and asks for another input.  
When the user types an odd number, display an error message, 
then ask for another input.  
When the user types the sentinel value  of 999, stop the program.
 
 Adapted from Farrell, Ch 6, 2
 
 J. M. Hinckley
 2024 
 */

package ex07;

import java.util.Scanner;

public class P02_evenEntryLoop {

	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		int number;
		String entry, message;
		final int QUIT = 999;
		System.out.print("Enter an even number or " + QUIT + " to quit: ");
		number = sc.nextInt();

		while (number != QUIT) {
			if (number % 2 == 0)
				message = "Correct";
			else
				message = number + " is not an even number";
			System.out.println(message + "\n");

			System.out.print("Enter an even number or " + QUIT + " to quit: ");
			number = sc.nextInt();
		}
		System.out.println("Done.");
	}
}
