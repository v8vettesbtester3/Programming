/*
 C# 07, Ex 01

Write a GUI C# program that inputs the length, width and height 
of a room in feet and the cost per square foot to paint a wall. 
Create a separate method that accepts these dimensions and cost/sqft 
as its parameters and calculates the cost of painting the room.

Adapted from Farrell Ch 7, Ex 3
J. M. Hinckley
2024
*/

namespace P01_paintingEstimate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(textBoxLength.Text);
            double width = Convert.ToDouble(textBoxWidth.Text);
            double height = Convert.ToDouble(textBoxHeight.Text);
            double pricepersqft = Convert.ToDouble(textBoxCostSqFt.Text);

            double totalPrice = calcTotalPrice(length, width, height, pricepersqft);

            textBoxTotalCost.Text = totalPrice.ToString("F2");
        }

        private double calcTotalPrice(double L, double W, double H, double Psqft)
        {
            double total = 0;
            double area = 2 * (L + W) * H;
            total = area * Psqft;

            return total;
        }
    }
}
