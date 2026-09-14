/*
 Java 06, Ex 01
 
 Using the if statement. 
 Write a Java program which asks the user to enter an integer.  
 Display a statement that indicates whether the integer is even or odd.
 
 J. M. Hinckley
 2024 
 */
package ex06;

import java.util.Scanner;

public class P01_evenOdd {

	public static void main(String[] args) {
	       Scanner input = new Scanner(System.in);
	       int number;
	       System.out.print("Enter a number >> ");
	       number = input.nextInt();
	       if(isEven(number))
	          System.out.println(number + " is even");
	       else
	          System.out.println(number + " is odd");
	   }
	   public static boolean isEven(int number)
	   {
	      boolean result;
	      if(number % 2 == 1)
	         result = false;
	      else
	         result = true;
	      return result;
	   }      

}
