/*
 * Java 04, Ex 01
 * 
 * Write a Java class named Student that has fields for an ID number, number of credit hours earned, 
 * and the number of points earned (credit hours * 4 = points).  
 * Include methods to assign values to all fields.  
 * Student also has a field for the grade point average.  
 * Include a method to compute the GPA by dividing points by credit hours earned.  
 * Write methods to display the values in each Student field.

* Write a default constructor for the Student class which initializes each Student’s ID to 9999, 
* credit hours to 3 and points earned to 4 * credit hours. 

* Write a second constructor that has parameters for the ID, the credit hours and points.
* 
* Write a Java class with a main method which demonstrates the default constructor by 
* instantiating an object and displaying its initial values and the GPA.
 * 
 * J. M. Hinckley
 * 2024
 */

package ex04;

public class P01_TestStudent {

	public static void main(String[] args) {
		System.out.println("First student:");
		Student pupil = new Student();
		pupil.setIdNumber(234);
		pupil.setHours(15);
		pupil.setPoints(45);

		pupil.showIDnumber();
		pupil.showPoints();
		pupil.showHours();
		System.out.println("The grade point average is " + pupil.getGradePoint());

		System.out.println("\n\nSecond student:");
		Student pupil2 = new Student(1234, 16, 54);
		pupil2.showIDnumber();
		pupil2.showPoints();
		pupil2.showHours();
		System.out.println("The grade point average is " + pupil2.getGradePoint());

	}

}
