/*
 Java 08, ex 02
 
Write a Java program that prompts the user for a password that contains at 
least two uppercase letters, at least three lowercase letters and at least one digit.  
Continuously prompt the user until a valid password is entered.  
Display a message indicating whether the password is valid; if not, 
display the reason why it is not valid.

J. M. Hinckley
2024
 */

package ex08;

import java.util.Scanner;

public class P02_validatePassword {

	public static void main(String[] args) {
		String aString;
		int stringLength;
		final int NUM_UPPER_LETTERS = 2;
		final int NUM_LOWER_LETTERS = 3;
		final int NUM_DIGITS = 1;
		Scanner in = new Scanner(System.in);
		// int numSpaces = 0;
		while (true) {
			int upperCount = 0;
			int lowerCount = 0;
			int digitCount = 0;
			int letterCount = 0;
			System.out.print("Enter a string >> ");
			aString = in.nextLine();
			stringLength = aString.length();

			for (int i = 0; i < stringLength; i++) {
				char ch = aString.charAt(i);
				if (Character.isUpperCase(ch))
					upperCount++;
				else if (Character.isLowerCase(ch))
					lowerCount++;
				else if (Character.isDigit(ch))
					digitCount++;
			}
			if (upperCount >= NUM_UPPER_LETTERS 
					&& lowerCount >= NUM_LOWER_LETTERS 
					&& digitCount >= NUM_DIGITS) {
				System.out.println("Valid password");
				break;
			} else {
				System.out.println("The password did not have enough of the following:");
				if (upperCount < NUM_UPPER_LETTERS)
					System.out.println("uppercase letters");
				if (lowerCount < NUM_LOWER_LETTERS)
					System.out.println("lowercase letters");
				if (digitCount < NUM_DIGITS)
					System.out.println("digits");
			}
		}
	}
}
