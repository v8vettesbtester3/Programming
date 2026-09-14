/*
Java 07, Ex 04

Using nested for-loops. 
Write a Java program that prints a triangle composed of the “T” 
character using nested for-loop and no more than three print statements.

Adapted from Farrell Ch6, ex 4
J. M. Hinckley
2024
 */

package ex07;

public class P04_triangleWithLoops {

	public static void main(String[] args) {
	      final int LINES = 8;
	      int lines;
	      int spaces = 8;
	      int letters = -1;
	      int x;
	      for(lines = 0; lines < LINES; ++lines)
	      {
	         for(x = 0; x < spaces; ++x)
	            System.out.print(" ");
	         for(x = 0; x < letters; ++x)
	            System.out.print("T"); 
	         System.out.println();
	         spaces--;
	         letters += 2;
	      }
	}

}
