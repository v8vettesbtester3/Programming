/*
 * C# 04, Ex 02
 * 
 * In a right triangle, the square of the length of one side is equal to the 
 * sum of the squares of the lengths of the other two sides. 
 * Write a GUI C# program that prompts the user to enter the lengths of 
 * three sides of a triangle then outputs a message indicating whether
 * the triangle is a right triangle or not.
 * 
 * J. M. Hinckley
 * 2024
 */


namespace P02_rightTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Calculate_Click_1(object sender, EventArgs e)
        {
            double side1, side2, side3;

            int intSide1, intSide2, intSide3;

            side1 = Convert.ToDouble(textBox1.Text);
            side2 = Convert.ToDouble(textBox2.Text);
            side3 = Convert.ToDouble(textBox3.Text);

            intSide1 = (int)(side1 * 100);
            intSide2 = (int)(side2 * 100);
            intSide3 = (int)(side3 * 100);

            if ((intSide1 * intSide1 == (intSide2 * intSide2 + intSide3 * intSide3)) ||
                (intSide2 * intSide2 == (intSide1 * intSide1 + intSide3 * intSide3)) ||
                (intSide3 * intSide3 == (intSide1 * intSide1 + intSide2 * intSide2)))

                textBoxResult.Text = "It is a right angled triangle.";
            else
                textBoxResult.Text = "It is not a right angled triangle.";

        }
    }
}
