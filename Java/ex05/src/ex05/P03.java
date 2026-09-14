/*
Java 05, Ex 03

Using this() as a constructor.  
Write a Java program that consists of a main() method and a second 
Java class named FitnessTracker (this will require two Java files: 
one for the main() method and a second one for the FitnessTracker class).
  
a. The FitnessTracker class has fields for the name of a fitness activity, 
the number of minutes spent participating in it and the date (use LocalDate).  

b. Write getters for each of these three private fields.

c. Write a constructor for the FitnessTracker class which receives 
   parameters for each of the three fields and assigns them appropriately.
   
d. Write a default constructor (this will be a second constructor), 
   which calls the first constructor (using this()), passing these values:
   * activity is “running”
   * duration is 0
   * date is January 1, this year
   * 
Write a main method which calls each of these methods 
(5 method calls: 2 constructors, 	getters).

 */
package ex05;

import java.time.*;

public class P03 {

	public static void main(String[] args) {
	      FitnessTracker exercise = new FitnessTracker();

	      System.out.println(exercise.getActivity() + " " + exercise.getMinutes() +
	         " minutes on " + exercise.getDate());

	 
	      LocalDate date = LocalDate.now();
	      FitnessTracker exercise2 = new FitnessTracker("bicycling", 35, date);

	      System.out.println(exercise2.getActivity() + " " + exercise2.getMinutes() +
	         " minutes on " + exercise2.getDate());
	   }
	}

