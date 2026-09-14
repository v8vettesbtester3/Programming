package ex02;

import java.util.Scanner;

public class P01 {
	/*
	 * Java 02, Exercise 01
	 * 
	 * Write a program that accepts the names of three political candidates 
	 * and the number of votes each received in the last election.  
	 * Display the percentage of the total vote that each received.
	 * 
	 * J. M. Hinckley
	 * 2024
	 */

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.print("Name of candidate #1: ");
		String name1 = sc.nextLine();
		System.out.print("Number of votes that "+name1+" received: ");
		int votes1 = sc.nextInt();
		sc.nextLine();   // flush buffer
		
		System.out.print("\nName of candidate #2: ");
		String name2 = sc.nextLine();
		System.out.print("Number of votes that "+name2+" received: ");
		int votes2 = sc.nextInt();
		sc.nextLine();   // flush buffer
		
		System.out.print("\nName of candidate #3: ");
		String name3 = sc.nextLine();
		System.out.print("Number of votes that "+name3+" received: ");
		int votes3 = sc.nextInt();
		sc.nextLine();   // flush buffer
		
		double multFactor = 100.0 / (votes1 + votes2 + votes3);
		
		double pct1 = votes1 * multFactor;
		double pct2 = votes2 * multFactor;
		double pct3 = votes3 * multFactor;
		
		System.out.println('\n'+name1 + " received "+ pct1+" percent.");
		System.out.println(name2 + " received "+ pct2+" percent.");
		System.out.println(name3 + " received "+ pct3+" percent.");
		
		sc.close();
	}

}
