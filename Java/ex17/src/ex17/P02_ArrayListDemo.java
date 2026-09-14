/*
 * Create a Java program that demonstrates the use of ArrayList.  
 * The ArrayList is to contain instances of a class Country.  
 * The class Country is to be composed of the following fields: 
 * name, capital, continent, population, area.  
 * The demonstration program should input from the console 
 * the data for an indeterminate number of Country objects.  
 * For each object input, the Country object should be added to the ArrayList.  
 * When the user is done entering data, the demonstration program 
 * should list the Country objects from the ArrayList in the order 
 * that they were added to the list.
 */

package ex17;

import java.util.ArrayList;
import java.util.Scanner;

class Country {
    private String name;
    private String capital;
    private String continent;
    private long population;
    private double area;

    // Constructor
    public Country(String name, String capital, String continent, long population, double area) {
        this.name = name;
        this.capital = capital;
        this.continent = continent;
        this.population = population;
        this.area = area;
    }

    // Override toString to display Country information
    @Override
    public String toString() {
        return "Country: " + name + 
               ", Capital: " + capital + 
               ", Continent: " + continent + 
               ", Population: " + population + 
               ", Area: " + area + " sq.km";
    }
}

public class P02_ArrayListDemo {

	public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        ArrayList<Country> countryList = new ArrayList<Country>();

        System.out.println("Enter country details (type 'done' as name to finish):");

        while (true) {
            System.out.print("Enter country name: ");
            String name = sc.nextLine();
            if (name.equalsIgnoreCase("done")) {
                break;
            }

            System.out.print("Enter capital: ");
            String capital = sc.nextLine();

            System.out.print("Enter continent: ");
            String continent = sc.nextLine();

            System.out.print("Enter population (in millions): ");
            long population = sc.nextLong();

            System.out.print("Enter area (in sq.km): ");
            double area = sc.nextDouble();

            // Consume the newline left by nextDouble()
            sc.nextLine();

            // Create and add a new Country object to the list
            Country country = new Country(name, capital, continent, population, area);
            countryList.add(country);
        }

        System.out.println("\nList of Countries:");
        for (Country country : countryList) {
            System.out.println(country);
        }

        sc.close();
    }

}
