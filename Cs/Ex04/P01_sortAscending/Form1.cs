namespace P01_sortAscending
{
    /*
    * C# 04, Ex 01
    * 
    * Write a GUI C# program that prompts the user to input three numbers. 
    * The program should then output the numbers in ascending order.
    *
    * J. M. Hinckley
    * 2024
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            double temp;

            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            num3 = Convert.ToDouble(textBox3.Text);

            if (num1 > num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }

            //Now num1 is less than or equal to num2


            if (num3 <= num1)
                textBoxResult.Text = num3.ToString() + ", " + num1.ToString() + ", " + num2.ToString();
            else if (num1 <= num3 && num3 <= num2)
                textBoxResult.Text = num1.ToString() + ", " + num3.ToString() + ", " + num2.ToString();
            else
                textBoxResult.Text = num1.ToString() + ", " + num2.ToString() + ", " + num3.ToString();

        }
    }
}
