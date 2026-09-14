/*
 * C# 02, Exercise 01
 * 
 * Write a program that accepts the names of three political candidates
 * and the number of votes each received in the last election.  
 * Display the percentage of the total vote that each received.
 * 
 * J. M. Hinckley
 * 2024
 */

namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name of candidate #1: ");
            string? name1 = Console.ReadLine();
            Console.Write("Number of votes that {0} received: ", name1);
            int votes1 = 0;
            string? s = Console.ReadLine();
            bool success = int.TryParse(s, out votes1);

            Console.Write("\nName of candidate #2: ");
            string? name2 = Console.ReadLine();
            Console.Write("Number of votes that {0} received: ", name2);
            int votes2 = 0;
            s = Console.ReadLine();
            success = int.TryParse(s, out votes2);

            Console.Write("\nName of candidate #3: ");
            string? name3 = Console.ReadLine();
            Console.Write("Number of votes that {0} received: ", name3);
            int votes3 = 0;
            s = Console.ReadLine();
            success = int.TryParse(s, out votes3);

            double multFactor = 100.0 / (votes1 + votes2 + votes3);

            double pct1 = votes1 * multFactor;
            double pct2 = votes2 * multFactor;
            double pct3 = votes3 * multFactor;

            Console.WriteLine("\n{0} received {1} percent.", name1, pct1);
            Console.WriteLine("{0} received {1} percent.", name2, pct2);
            Console.WriteLine("{0} received {1} percent.", name3, pct3);
        }
    }
}
