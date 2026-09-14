using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_AnyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

            // Check if the list contains any elements
            if (fruits.Any())
            {
                Console.WriteLine("The list is not empty.");
            }

            // Check if any fruit starts with 'B'
            bool startsWithB = fruits.Any(fruit => fruit.StartsWith("B"));
            Console.WriteLine($"Any fruit starts with 'B': {startsWithB}");
        }
    }
}
