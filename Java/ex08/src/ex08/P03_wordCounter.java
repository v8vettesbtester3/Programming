/*
 Java 08, ex 03
 
Write a Java program that counts the words in a String entered by the user.  
Words are separated by any combination of spaces, periods, commas, 
semicolons, question marks, exclamation points or dashes.

J. M. Hinckley
2024
 */

package ex08;

import java.util.Scanner;

public class P03_wordCounter {

	public static void main(String[] args) {
		String str;
		Scanner in = new Scanner(System.in);
		char ch;
		int x;
		while (true) {
			int count = 0;
			int length;
			boolean previousCharWasPunc = false;
			System.out.print("Enter a string (\"QUIT\" to end) >> ");
			str = in.nextLine();
			if (str.equals("QUIT")) break;
			length = str.length();
			for (x = 0; x < length; x++) {
				ch = str.charAt(x);
				if (ch == ' ' || ch == '.' || ch == ';' || ch == ',' 
						|| ch == '!' || ch == '-') {
					++count;
					if (previousCharWasPunc)
						--count;
					previousCharWasPunc = true;
				} else
					previousCharWasPunc = false;
			}
			if (!previousCharWasPunc)
				++count;

			System.out.println("There are " + count + " words in the string");
		}
		System.out.println("Done.");
	}

}
