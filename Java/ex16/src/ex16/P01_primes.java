// BPA RLC 2009

/* Contestant Number: 
 * Date:
 * 
 * This program will determine if a number is prime, not prime or an emirp.
 */

package ex16;

import java.util.Scanner;

public class P01_primes {

	public static void main(String[] args) {
		Scanner keyboard = new Scanner (System.in);
		
		int choice=1;
		
		while (choice !=0) {
			choice = keyboard.nextInt();
			keyboard.nextLine();
			
			if (choice > -1 && choice < 32768){
				if (choice !=0){
					if (prime(choice)&& prime( reverse(choice) )&&( choice != reverse(choice)) ) 
						System.out.println(choice + " is an emirp\n");
					else if (prime(choice))
						System.out.println(choice + " is prime\n");
					else
						System.out.println(choice + " is not prime\n");
				}
			}
			else
				System.out.println("Invalid data entry.  Number must be between 0 and 32767\n");
				
		}

	}
	
/* this method determines if a number is prime */
	
	public static boolean prime(int number){
		boolean isPrime=true;
		int divisor=2;
		while (divisor < number && isPrime==true){
			if ((number % divisor) == 0)
				isPrime=false;
			divisor++;
		}
		return (isPrime);
	}
	
/*This method returns the reverse of a number */
	
	public static int reverse(int number){
		int total=0;
		int digits =1;
		while ((int)(number/Math.pow(10,digits))!=0)
			++digits;
		for (int ii=1;ii<=digits;ii++){
			total+=number % 10 * Math.pow(10,digits-ii);
			number/=10;
		}
		return total;
	}

	

}
