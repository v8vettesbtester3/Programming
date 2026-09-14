/*
 Java 07, Ex 01
 
 Using the for-loop.  
 Write a Java program in which the user enters a value by which to count.  
 The program counts by increments of this number from one times the number
  to 100 times the number.  
  Print the output in a rectangular table with 10 values per row, 50 rows total.
  Control the format so that you have at least two spaces between 
  columns and the numbers are right-justified in their columns.
 
 Adapted from Farrell, Ch 6, 1b
 
 J. M. Hinckley
 2024 
 */

package ex07;

import java.util.Scanner;

public class P01_countByAnything {

	   public static void main (String args[])
	   {
	      Scanner sc = new Scanner(System.in);
	      System.out.print("Enter number to count by >> ");
	      int stepValue = sc.nextInt();
	      
	      // Find out how many digits last number has
	      // to determine how many characters to allot per column.
	      int lastVal = 500 * stepValue;
	      int colWidth = 0;
	      while (lastVal > 0) {
	    	  lastVal /= 10;
	    	  colWidth++;
	      }
	      String sFmt = "%"+(colWidth+2)+"d";
	      
	      
	      for(int i = 0; i < 500; i++)
	      {
	    	  int val = (i+1)*stepValue;
	         System.out.printf(sFmt, val);
	         if((i+1) % 10 == 0)
	            System.out.println();
	      }
	   }

}
