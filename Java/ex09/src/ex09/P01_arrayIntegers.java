/*
 Java 09, Ex 1
 
 Write a Java program that stores nine integers in an array.  
 Display the integers from first to last, and then display the 
 integers from last to first.
 
 J. M. Hinckley
 2024
 */
package ex09;

public class P01_arrayIntegers {

	public static void main(String[] args) {
	      int[] numbers = {10, 15, 19, 23, 26, 29, 31, 34, 38};
	      int i;
	      for (i = 0; i < numbers.length; i++)
	         System.out.print(numbers[i] + "  ");
	      System.out.println();
	      for (i = numbers.length - 1; i >= 0; i--)
	         System.out.print("" + numbers[i] + "  ");
	      System.out.println();
	}

}
