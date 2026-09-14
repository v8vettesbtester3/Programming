/*
 * C# 03, Ex 02
 * 
 * A farm sells eggs at the rate of $3.25 per dozen or 45 cents per individual egg, 
 * not part of a dozen.  
 * Write a GUI program that accepts the number of eggs and displays the amount owed
 * with a breakdown of the number of dozens, the price per dozen, 
 * the number of extra eggs and the price per extra.
 *
 * J. M. Hinckley
 * 2024
 */
namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            int totalNumEggs = Convert.ToInt32(totalEggCountBox.Text);

            int numDoz = totalNumEggs / 12;
            int numXtra = totalNumEggs % 12;

            double pricePerDoz = 3.25;
            double pricePerSngl = 0.45;

            QuantBox1.Text = numDoz.ToString();
            QuantBox2.Text = numXtra.ToString();

            ItemBox1.Text = "Dozen Eggs";
            ItemBox2.Text = "Single Eggs";

            PrEachBox1.Text = pricePerDoz.ToString();
            PrEachBox2.Text = pricePerSngl.ToString();

            PrTotalBox1.Text = (numDoz * pricePerDoz).ToString("F2");
            PrTotalBox2.Text = (numXtra * pricePerSngl).ToString("F2");

            totalCostBox.Text = (numDoz * pricePerDoz + numXtra * pricePerSngl).ToString("F2");
        }
    }
}
