namespace P01_exceptionSubscript
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = {20.3, 44.6, 32.5, 46.7, 89.6,
                        67.5, 12.3, 14.6, 22.1, 13.6};
            int sub;
            const int QUIT = 99;
            Console.Write("Enter a subscript value or {0} to quit >> ", QUIT);
            int.TryParse(Console.ReadLine(), out sub);
            while (sub != QUIT)
            {
                try
                {
                    Console.WriteLine("The value is {0}", array[sub]);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.Write("Enter a subscript value or {0} to quit >> ", QUIT);
                int.TryParse(Console.ReadLine(), out sub);
            }
        }
    }
}
