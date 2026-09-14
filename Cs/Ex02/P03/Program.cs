/*
 * C# 02, Exercise 03
 * 
 * Write a program that displays the cosine and sine values for 
 * angles from zero to 360 degrees, in steps of 45 degrees.
 * 
 * J. M. Hinckley
 * 2024
 */

namespace P03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for (int angle = 0; angle <= 360; angle += 45)
            {
                double c = Math.Cos(angle * Math.PI / 180.0);
                double s = Math.Sin(angle * Math.PI / 180.0);
                Console.WriteLine("{0,5}{1,10}{2,10}", angle.ToString("D"), c.ToString("F4"), s.ToString("F4"));
            }
        }
    }
}
