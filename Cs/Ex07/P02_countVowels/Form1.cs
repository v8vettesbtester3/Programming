/*
 C# 07, Ex02

Write a GUI C# program that inputs a string and passes it to 
a method that returns the number of vowels in the string.

Adapted from Ferrell Ch 7, Ex 8]
J. M. Hinckley
2024
 */

namespace P02_countVowels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            string s = textBoxInput.Text;

            int c = getVowelCount(s);

            textBoxCount.Text = c.ToString();
        }

        private int getVowelCount(string s)
        {
            int x, y;
            int count = 0;
            string[] vowels = { "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "y" };
            for (x = 0; x < s.Length; ++x)
                for (y = 0; y < vowels.Length; ++y)
                    if (String.Equals(s.Substring(x, 1), vowels[y]))
                        ++count;

            return count;
        }
    }
}
