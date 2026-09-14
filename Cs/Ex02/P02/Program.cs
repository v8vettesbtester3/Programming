/*
 * C# 02, Exercise 02
 * 
 * A farm sells eggs at the rate of $3.25 per dozen or 45 cents per 
 * individual egg, not part of a dozen. 
 * 
 * Write a program that prompts the user for the number of eggs and 
 * displays the amount owed  with a full explanation.  
 * 
 * For example: “You ordered 27 eggs. 
 * That’s 2 dozen at $3.25 per dozen 
 * and 3 loose eggs at 45 cents each, 
 * for a total of $7.85.”.
 * 
 * J. M. Hinckley
 * 2024
 */

namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of eggs: ");
            int numEggs = 0;
            string? s = Console.ReadLine();
            bool success = int.TryParse(s, out numEggs);
            if (success)
            {
                int numDozen = numEggs / 12;
                int numExtras = numEggs % 12;

                double costDollars = 3.25 * numDozen + 0.45 * numExtras;

                Console.WriteLine("You ordered {0} eggs.", numEggs);
                Console.WriteLine("That’s {0} dozen at $3.25 per dozen", numDozen);
                Console.WriteLine("and {0} loose eggs at 45 cents each,", numExtras);
                Console.WriteLine("for a total of {0}.", costDollars.ToString("C2"));
            }
        }
    }
}
