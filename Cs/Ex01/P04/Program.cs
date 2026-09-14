/*
 * C# 01, Exercise 04
 * 
 * Write a C# program that asks and inputs from the user the length 
 * of an edge of a cube and prints the cube’s surface area.
 * 
 * J. M. Hinckley
 * 2024
 */

namespace P04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the edge of a cube: ");
            double length = 0;
            string? s = Console.ReadLine();
            bool success = double.TryParse(s, out length);
            if (success)
            {
                Console.WriteLine("Area = {0}", 6 * length * length);
            }
        }
    }
}
