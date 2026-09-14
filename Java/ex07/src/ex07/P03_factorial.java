/*
 Java 07, Ex 3
 
 Using nested for-loops. 
Write a Java program that displays the factorial for every integer from 1 to 10.  
The factorial of a number is the product of that number multiplied by each 
positive integer below it.  Example: 4 factorial is 4*3*2*1 = 24.

Adapted from Farrell Ch6, Ex 3
J. M. Hinckley
2024
 */

package ex07;

public class P03_factorial {

	public static void main(String[] args) {
	      final int MAX = 10;
	      int factorial;
	      for (int i = 1; i <= MAX; i++)
	      {
	         factorial = i;
	         for(int j = i - 1; j > 0; --j)
	             factorial = factorial * j;
	         System.out.println("The factorial of " + i +
	           " is " + factorial);
	      }
	}

}
