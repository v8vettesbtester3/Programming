/*
 * Java 03, Ex 01
 * 
 * Write a Java program whose main() which queries the user 
 * for two integer values.  
 * Then it passes each value to each of three methods, named:
 * displayTwiceTheNumber(),
 * displayNumberPlusFive(),
 * displayNumberSquared().
 * Write each of these methods
 *
 * J. M. Hinckley
 * 2024
 */

package ex03;

import java.util.Scanner;

public class P01_NumbersDemo {

	   public static void main (String args[])
	   {
	      Scanner kb = new Scanner(System.in);
	      int num1, num2;
	            System.out.print("Enter an integer >> ");
	      num1 = kb.nextInt();
	      System.out.print("Enter another integer >> ");
	      num2 = kb.nextInt();
	      displayTwiceTheNumber(num1);
	      displayNumberPlusFive(num1);
	      displayNumberSquared(num1);
	      displayTwiceTheNumber(num2);
	      displayNumberPlusFive(num2);
	      displayNumberSquared(num2);
	   }
	   public static void displayTwiceTheNumber(int n)
	   {
	      final int FACTOR = 2;
	      System.out.println(n + " times " + FACTOR + " is " + (n * FACTOR));
	   }
	   public static void displayNumberPlusFive(int n)
	   {
	      final int FACTOR = 5;
	      System.out.println(n + " plus " + FACTOR + " is " + (n + FACTOR));
	   }
	   public static void displayNumberSquared(int n)
	   {
	      System.out.println(n + " squared is " + (n * n)); 
	   }

}
