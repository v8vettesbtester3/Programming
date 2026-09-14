package ex02;

/*
 * Java 02, Exercise 03
 * 
 * Write a program that displays the cosine and sine values 
 * for angles from zero to 360 degrees, in steps of 45 degrees.
 * 
 * J. M. Hinckley
 * 2024
 */

public class P03 {
	public static void main(String[] args) {
		
		for (int angle = 0; angle <= 360; angle += 45) {
			double c = Math.cos(angle * Math.PI / 180.0);
			double s = Math.sin(angle * Math.PI / 180.0);
			System.out.println(String.format("%5d   %10.4f  %10.4f", angle, c, s));
		}
		
	}
}
