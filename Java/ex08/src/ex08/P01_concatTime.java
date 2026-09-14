/*
 Java 08, ex 01
 
Write a Java program that creates a string three different ways.
Allocate an empty string.
Allocate an empty StringBuilder object.
Allocate a StringBuilder object with a capacity of 800,000.

J. M. Hinckley
2024
 */

package ex08;

import java.time.*;

public class P01_concatTime {

	public static void main(String[] args) {
		long startTimeNano, endTimeNano;
		long startTimeSec, endTimeSec;
		final int TIMES = 200000;
		final int FACTOR = 1000000;
		int x;
		String string0 = "";
		StringBuilder string1 = new StringBuilder("");
		StringBuilder string2 = new StringBuilder(TIMES*4);
		LocalDateTime now;
		
		// String concatenation
		now = LocalDateTime.now();
		startTimeSec = now.getSecond();
		startTimeNano = now.getNano();
		for (x = 0; x < TIMES; ++x) {
			string0 += "Java";
		}
		now = LocalDateTime.now();
		endTimeSec = now.getSecond();
		endTimeNano = now.getNano();
		System.out.println("Time with String: "
		+((endTimeSec-startTimeSec)*1000+(endTimeNano-startTimeNano)/FACTOR) 
		+ " ms");

		// Appending to StringBuilder without preallocation of capacity
		now = LocalDateTime.now();
		startTimeSec = now.getSecond();
		startTimeNano = now.getNano();
		for (x = 0; x < TIMES; ++x) {
			string1.append("Java");
		}
		now = LocalDateTime.now();
		endTimeSec = now.getSecond();
		endTimeNano = now.getNano();
		System.out.println("Time with empty StringBuilder: "
		+((endTimeSec-startTimeSec)*1000+(endTimeNano-startTimeNano)/FACTOR) 
		+ " ms");

		// Appending to StringBuilder with preallocated capacity
		now = LocalDateTime.now();
		startTimeSec = now.getSecond();
		startTimeNano = now.getNano();
		for (x = 0; x < TIMES; ++x) {
			string2.append("Java");
		}
		now = LocalDateTime.now();
		endTimeSec = now.getSecond();
		endTimeNano = now.getNano();
		System.out.println("Time with assigned capacity StringBuilder: "
		+((endTimeSec-startTimeSec)*1000+(endTimeNano-startTimeNano)/FACTOR) 
		+ " ms");
	}
}
