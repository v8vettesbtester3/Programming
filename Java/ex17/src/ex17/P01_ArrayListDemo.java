// Demo ArrayList

package ex17;

import java.util.ArrayList;

public class P01_ArrayListDemo {

	public static void main(String[] args) {
	    // Create an ArrayList of Strings
        ArrayList<String> fruits = new ArrayList<String>();

        // Add elements to the ArrayList
        fruits.add("Apple");
        fruits.add("Banana");
        fruits.add("Cherry");

        // Access an element
        System.out.println("First fruit: " + fruits.get(0));

        // Remove an element
        fruits.remove("Banana");

        // Check if an element exists
        if (fruits.contains("Cherry")) {
            System.out.println("Cherry is in the list!");
        }

        // Iterate through the ArrayList
        for (String fruit : fruits) {
            System.out.println(fruit);
        }
	}

}
