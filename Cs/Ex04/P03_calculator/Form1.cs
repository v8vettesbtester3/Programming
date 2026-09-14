/*
 * C# 04, Ex 03
 * 
 * Write a GUI C# program that mimics a calculator.  
 * The program should take as input two integers and the operation to be performed.  
 * It should then output the numbers, the operator and the result.  
 * For division if the denominator is zero, output an appropriate message.  
 * Use a switch statement, switching on the operator character to 
 * determine the operation to carry out.
 * 
 * J. M. Hinckley
 * 2024
 */


namespace P03_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double num1, num2;
            char opr;

            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            opr = Convert.ToChar(textBox3.Text);

            switch (opr)
            {
                case '+':
                    textBoxResult.Text = num1.ToString() + " + " + num2.ToString() + " = " + (num1 + num2).ToString();
                    break;
                case '-':
                    textBoxResult.Text = num1.ToString() + " - " + num2.ToString() + " = " + (num1 - num2).ToString();
                    break;
                case '*':
                    textBoxResult.Text = num1.ToString() + " * " + num2.ToString() + " = " + (num1 * num2).ToString();
                    break;
                case '/':
                    if (num2 != 0)
                        textBoxResult.Text = num1.ToString() + " / " + num2.ToString() + " = " + (num1 / num2).ToString();
                    else
                        textBoxResult.Text = "ERROR.  Cannot divide by zero.";
                    break;
                default:
                    textBoxResult.Text = "Illegal operation.";
                    break;
            }



        }
    }
}
