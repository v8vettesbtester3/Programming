package ex03;

/*
 Java 03, Exercise 03

Create a Java program that tests your ability to interpret binary
and hexadecimal numbers.

a. Ask the user to choose to be presented with either binary or hexadecimal
   values.
b. The program randomly picks a number between 0 and 255.
c. Initialize a counter of the number of user’s attempts to zero.
d. Print this value in the chosen base.
   For example if the randomly picked number is 27 and hexadecimal
   representation was chosen, print 0x1B, which is the hex representation of 27.
e. Increment the number of attempts by 1.
f. Input the user’s answer for the base-10 value of the presented number.
   For example, the program prints 0x1B and the user is then asked to
   enter what they think this is in base 10 (it’s 27).
g. If the answer is correct, print
   “Congratulations, you answered in “, <number of attempts>,” tries”.
h. Otherwise, when the answer is not correct, print “Nope.  “
   and ask the user to again input their answer.
i. The game continues until the correct answer is provided, whereupon the number of attempts is displayed.

 */

import java.util.Scanner;
import java.util.Random;

public class P03_BinHex {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		Random r = new Random();
		
		int tryCount = 0;
		int b = -1;
		while (b != 0 && b != 1) {
			System.out.print("Enter 0 for binary or 1 for hex: ");
			b = sc.nextInt();
		}
		sc.nextLine();
		
		int numToGuess = r.nextInt(256);
		
		if (b == 0) {
			// binary
			String val = Integer.toString(numToGuess,2);
			System.out.println("0b"+val);
		}
		else {
			// hex
			String val = Integer.toString(numToGuess,16);
			System.out.println("0x"+val);
		}
		
		int guess = -1;
		while (guess != numToGuess) {
			tryCount++;
			System.out.print("Enter your answer in base 10: ");
			guess = sc.nextInt();
			
			if (guess == numToGuess) {
				break;
			}
			else {
				System.out.print("Nope.  ");
			}
		}
		
		System.out.println("Congratulations, you answered correctly, in " + tryCount +" attempts.");

	}

}
