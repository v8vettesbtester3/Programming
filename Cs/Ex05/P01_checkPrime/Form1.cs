
/*
C# 05, Ex 01

Write a C# program that prompts the user to input a positive integer.  
Make the program robust to not crash if something other than an integer is input.  
Keep asking for input until a positive integer is input. 
Then determine whether the integer is a prime number.  
Output a message saying whether or not it is prime.

J. M. Hinckley
2024
*/

namespace P01_checkPrime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int number = 0;
            double dnum=0;
            bool isPrime = true;

            int sqrtNum;
            int divisor = 3;

            resultTxtBox.Text = "";

            while (true)
            {
                bool success = false;
                while (!success)
                {
                    success = Double.TryParse(inputTxtBox.Text, out dnum );
                    if ( !success)
                    {
                        MessageBox.Show("Enter an integer > 1.");
                        return;
                    }
                }

                if (dnum > 1 && (dnum == (int)(dnum)))
                {
                    number = (int)(dnum);
                    break;
                }
                else
                {
                    MessageBox.Show("Enter an integer > 1.");
                    return;
                }
            }


            if (number == 2)
                resultTxtBox.Text = "It is a prime number";
            else if (number % 2 == 0)
                resultTxtBox.Text = "It is not a prime number";
            else
            {
                sqrtNum = (int)(Math.Sqrt((double)number));

                while (divisor <= sqrtNum)
                {
                    if (number % divisor == 0)
                    {
                        resultTxtBox.Text = "It is not a prime number";
                        isPrime = false;
                        break;
                    }
                    else
                        divisor = divisor + 2;
                }

                if (isPrime)
                    resultTxtBox.Text = "It is a prime number";
            }


        }
    }
}
