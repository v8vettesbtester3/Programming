/*
 * Java 03, Ex 02
 * 
 * Write a Java program that prompts the user for the length, 
 * width and height of a rectangular room.  
 * This program will give information about painting the room.  
 * Pass the three dimensions to a method that does the following:
 * calculates the wall area of the room
 * passes the wall area to another method that calculates 
 * and returns the number of gallons of paint needed.  
 * Assume that one gallon will cover 350 square feet.
 * displays the number of gallons needed
 * computes the price of the paint, based on the rate of $32/gallon.
 * returns the price to the main() method.
 * The main() method then displays the final price.
 * Test this with the dimensions for a room that is 
 * 15 by 20 feet with a 10-foot ceiling.
 *
 * J. M. Hinckley
 * 2024
 */

package ex03;

import java.util.Scanner;

public class P02_PaintCalculator {

	  public static void main (String args[])
	  {
	     double length, width, height;
	     double price;
	     Scanner kb = new Scanner(System.in);
	     System.out.print("Enter the room's length >> ");
	     length = kb.nextDouble();
	     System.out.print("Enter the room's width >> ");
	     width = kb.nextDouble();
	     System.out.print("Enter the room's height >> ");
	     height = kb.nextDouble();
	     price = computeArea(length, width, height);
	     System.out.println("The price to paint the room is $" + price);
	   }

	   public static double computeArea(double length, double width, double height)
	   {
	      final double PRICE_GALLON = 32;
	      double area = length * height * 2 + width * height * 2;
	      double gallons;
	      double price;
	      gallons = computeGallons(area);
	      System.out.println("You will need " + gallons + " gallons");
	      price = gallons * PRICE_GALLON;
	      return price;
	   }
	   public static double computeGallons(double area)
	   {
	       final int SQFT_PER_GAL = 350;
	       double gallons = area / SQFT_PER_GAL;
	       return gallons;
	   }

}
