namespace P02_argumentExeption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int QUIT = 999;
            int waterTemp;
            bool isComfortable;
            Console.Write("Enter temperature or {0} to quit >> ", QUIT);
            int.TryParse(Console.ReadLine(), out waterTemp);
            while (waterTemp != QUIT)
            {
                try
                {
                    isComfortable = CheckComfort(waterTemp);
                    if (isComfortable)
                        Console.WriteLine("{0} degrees is comfortable for swimming.", waterTemp);
                    else
                        Console.WriteLine("{0} degrees is not comfortable for swimming.", waterTemp);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                Console.Write("Enter another temperature or {0} to quit >> ", QUIT);
                int.TryParse(Console.ReadLine(), out waterTemp);
            }
        }

        public static bool CheckComfort(int temp)
        {
            bool isComfortable = true;
            const int LOW = 32;
            const int HIGH = 212;
            const int LOWCOMFORT = 70;
            const int HIGHCOMFORT = 85;
            if (temp < LOW || temp > HIGH)
                throw (new ArgumentException());
            if (temp < LOWCOMFORT || temp > HIGHCOMFORT)
                isComfortable = false;
            return isComfortable;
        }

    }
}
