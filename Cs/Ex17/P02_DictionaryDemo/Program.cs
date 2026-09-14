using System;
using System.Collections.Generic;

namespace P02_DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, object>> countries = new List<Dictionary<string, object>>();
            Console.WriteLine("Enter country details. Type 'done' as the country name to finish.");

            while (true)
            {
                // Input country name
                Console.Write("Enter country name: ");
                string name = Console.ReadLine();
                if (name.Equals("done", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                // Create a new dictionary to store country details
                Dictionary<string, object> country = new Dictionary<string, object>
            {
                { "Name", name }
            };

                // Input remaining details
                Console.Write("Enter capital: ");
                country["Capital"] = Console.ReadLine();

                Console.Write("Enter continent: ");
                country["Continent"] = Console.ReadLine();

                Console.Write("Enter population (in millions): ");
                int population;
                while (!int.TryParse(Console.ReadLine(), out population))
                {
                    Console.Write("Invalid input. Enter population as an integer: ");
                }
                country["Population"] = population;

                Console.Write("Enter area (in sq.km): ");
                double area;
                while (!double.TryParse(Console.ReadLine(), out area))
                {
                    Console.Write("Invalid input. Enter area as a double: ");
                }
                country["Area"] = area;

                // Add the dictionary to the list
                countries.Add(country);

                Console.WriteLine("Country added.\n");
            }

            // Display all countries
            Console.WriteLine("\nList of countries:");
            foreach (var country in countries)
            {
                Console.WriteLine($"Country: {country["Name"]}");
                Console.WriteLine($"  Capital: {country["Capital"]}");
                Console.WriteLine($"  Continent: {country["Continent"]}");
                Console.WriteLine($"  Population: {country["Population"]} million");
                Console.WriteLine($"  Area: {country["Area"]} sq.km\n");
            }
        }
    }
}
