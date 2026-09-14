/*
Java 10, Ex 01
 
Bubble sorting

Write a Java program that uses bubble sorting to sort unique random integers.

a. Input from the console how many random integers to generate.  
   Assign this value to SAMPLE_SIZE.

b. Make a loop generating this many random integers. 
   Store them in an array named nums.

c. Use bubble sorting to sort the random integers.  Count two things as you do this:
   1. count the number of comparisons
   2. count the number of swaps
   
d. At the end of the bubble sorting, calculate the ratio of # swaps to # comparisons

e. Print this ratio

f. Run the program.  Use a sample size of 1000.  What is the ratio?  
   Intuitively, is this what you would expect?

g. Modify your program to do this experiment many times (TRIAL_COUNT).

h. Query the user for the number of trials and assign the input value to TRIAL_COUNT.

i. Run your program again and look at the distribution of the ratios of 
   #swaps to #comparisons.  Statistically, what does it tend to average?

j. Make an array to store the ratios.  The array should have a length of TRIAL_COUNT.

k. Move your code for bubble sorting to a function, which in addition to sorting, 
   returns the value of the ratio.

l. Next, prepare to list the ratios in ascending order to visually see their distribution.  
   Start by overloading your bubble sort function to be able to sort an array of doubles.

m. After generating the array of ratios, use the bubble sort function to sort them 
   and print out the sorted array.  
   Observe how they strongly are grouped around their mean value as the sample size increases.

n. Add code to histogram these values by creating a 100-element integer array, named hist.

o. Loop over the array of ratios, binning them.  This means if a ratio is between  
   0.495 and 0.505, add 1 to hist[50],  if it’s between 0.505 and 0.515, add 1 to hist[51], etc.

p. Print the values of hist.

q. Copy and paste these values into a text document and use Excel to draw a histogram of the data.

 
 */

package ex10;

import java.util.Random;
import java.util.Scanner;

public class P01_bubbleSort {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter sample size: ");
		int SAMPLE_SIZE = sc.nextInt();
		System.out.print("Enter number trials: ");
		int TRIAL_COUNT = sc.nextInt();
		Random r = new Random();
		double[] ratios = new double[TRIAL_COUNT];
		boolean[] picked = new boolean[SAMPLE_SIZE];
		int[] nums = new int[SAMPLE_SIZE];
		// Header for monitoring progress
		System.out.print("|");
		for (int i = 1; i < 99; i++) System.out.print("-");
		System.out.println("|");
		
		for (int itrial = 0; itrial < TRIAL_COUNT; itrial++) {
			for (int i = 0; i < SAMPLE_SIZE; i++) {
				picked[i] = false;
				nums[i] = 0;
			}
			int idx = 0;
			int q = 0;
			for (idx = 0; idx < SAMPLE_SIZE; idx++) {
				do {
					q = r.nextInt(SAMPLE_SIZE);
				} while (picked[q]);
				picked[q] = true;
				nums[idx] = q;
				// System.out.printf("%5d %5d\n",idx, q);
			}

			int numComparisons = 0;
			int numSwaps = 0;
			int comparisonsToMake = nums.length - 1;
			for (int a = 0; a < nums.length - 1; a++) {
				for (int b = 0; b < comparisonsToMake; b++) {
					numComparisons++;
					if (nums[b] > nums[b + 1]) {
						numSwaps++;
						int temp = nums[b];
						nums[b] = nums[b + 1];
						nums[b + 1] = temp;
					}
				}
				comparisonsToMake--;
			}
//			System.out.println("-------------- Sorted -------------");
//			for (idx = 0; idx < SAMPLE_SIZE; idx++) {
//				System.out.printf("%5d %5d\n", idx, nums[idx]);
//			}
//
//			System.out.println("\nNumber of comparisons: " + numComparisons);
			ratios[itrial] = numSwaps*1.0/numComparisons;
			//ratios[itrial] = bubbleSort(nums);
			System.out.printf("Number of swaps/number of comparisons: %6.3f\n", ratios[itrial]);
			
			System.out.println("-------------- Sorted -------------");
			for (idx = 0; idx < SAMPLE_SIZE; idx++) {
				System.out.printf("%5d %5d\n", idx, nums[idx]);
			}
			
//			// Monitoring progress
//			if ((itrial+1) % (TRIAL_COUNT/100) == 0 )
//			System.out.print("*");

		} // end of loop over trials
		System.out.println();
		
//		bubbleSort(ratios);
//		for (int i = 0; i < TRIAL_COUNT; i++) {
//			System.out.printf("%5d %6.3f\n", i, ratios[i]);
//		}
		final int NUM_BINS = 100;
		int[] hist = new int[NUM_BINS];
		for (int i = 0; i < TRIAL_COUNT; i++) {
			int idx = (int)(ratios[i] * NUM_BINS+0.5);
			hist[idx]++;
		}
		System.out.println("-----------------Histogram-------------------");
		for (int i = 0; i < NUM_BINS; i++) {
			System.out.printf("%5d  %5d\n", i, hist[i]);
		}
		
		System.out.println("Done.");

	}
	
//	public static double bubbleSort(int[] iArray) {
//		int numComparisons = 0;
//		int numSwaps = 0;
//		int comparisonsToMake = iArray.length - 1;
//		for (int a = 0; a < iArray.length - 1; a++) {
//			for (int b = 0; b < comparisonsToMake; b++) {
//				numComparisons++;
//				if (iArray[b] > iArray[b + 1]) {
//					numSwaps++;
//					int temp = iArray[b];
//					iArray[b] = iArray[b + 1];
//					iArray[b + 1] = temp;
//				}
//			}
//			comparisonsToMake--;
//		}
//		return numSwaps*1.0/numComparisons;
//	}
//
//	public static double bubbleSort(double[] dArray) {
//		int numComparisons = 0;
//		int numSwaps = 0;
//		int comparisonsToMake = dArray.length - 1;
//		for (int a = 0; a < dArray.length - 1; a++) {
//			for (int b = 0; b < comparisonsToMake; b++) {
//				numComparisons++;
//				if (dArray[b] > dArray[b + 1]) {
//					numSwaps++;
//					double temp = dArray[b];
//					dArray[b] = dArray[b + 1];
//					dArray[b + 1] = temp;
//				}
//			}
//			comparisonsToMake--;
//		}
//		return numSwaps*1.0/numComparisons;
//	}

}
