package ex01;

import java.util.Scanner;

public class P04 {
	/*
	 * Java 01, Exercise 04
	 * 
	 * Write a Java program that asks and inputs from the user the length of 
	 * an edge of a cube and prints the cube’s surface area.
	 * 
	 * J. M. Hinckley
	 * 2024
	 */

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Enter the length of an edge of a cube: ");
		double x = sc.nextDouble();
		
		double area = 6 * x * x;
		
		System.out.println("Surface area = "+area);
	}

}
