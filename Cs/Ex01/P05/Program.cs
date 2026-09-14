/*
 * C# 01, Exercise 05
 * 
 * Write a C# program that inputs from the user a number of minutes.  
 * It then calculates what this is in terms of days, hours and minutes.  
 * For example 2000 minutes = 1 day, 9 hours and 20 minutes.
 * 
 * J. M. Hinckley
 * 2024
 */

namespace P05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of minutes: ");
            int totalMinutes = 0;
            string? s = Console.ReadLine();
            bool success = int.TryParse(s, out totalMinutes);
            if (success)
            {
                int minutes = totalMinutes; // working value, to be modified

                int days = minutes / (60 * 24); // 60 * 24 minutes / day
                minutes = minutes % (60 * 24);  // # minutes beyond whole # days

                int hours = minutes / 60;       // 60 minutes / hour
                minutes = minutes % 60;         // # minutes beyond whole # hours

                Console.WriteLine("{0} minutes = {1} days, {2} hours and {3} minutes.",
                    totalMinutes, days, hours, minutes);
            }
        }
    }
}
