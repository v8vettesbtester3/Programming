/*
 C# 07, Ex 03

Write a GUI C# program that allows the user to enter multiple integer
s into a text box, 
reads the text box and parses the string into an array of integers.  
Then it passes the array of integers to a method that calculates
their sum and returns this value.  The sum value is displayed.

Adapted from Farrell Ch 7, #x 10.
J. M. Hinckley
2024
 */
namespace P03_flexibleArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox2.Text;

            int[] vals = s.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries) // Split by space
                             .Select(int.Parse) // Convert each element to int
                             .ToArray(); // Convert to an array
 
            int total = SumNums(vals);  
            textBox1.Text = total.ToString();
        }

        private int SumNums(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            return total;
        }
    }
}
