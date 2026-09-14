using System.Diagnostics.Metrics;

namespace P01_letterInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Letter letter1 = new Letter();
            CertifiedLetter letter2 = new CertifiedLetter();
            letter1.Name = "Electric Company";
            letter1.Date = "02/14/18";
            letter2.Name = "Howe and Morris, LLC";
            letter2.Date = "04/01/2019";
            letter2.TrackingNumber = "i2YD45";
            Console.WriteLine(letter1.ToString());
            Console.WriteLine();
            Console.WriteLine(letter2.ToString());
        }
    }

    class Letter
    {
        public string? Name { get; set; }
        public string? Date { get; set; }
        public new virtual string ToString()
        {
            return (GetType() + "\nTo: " + Name +
               "\nDate mailed : " + Date);
        }
    }
    class CertifiedLetter : Letter
    {
        public string? TrackingNumber { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\nTracking number: "+TrackingNumber;
        }
    }

}
