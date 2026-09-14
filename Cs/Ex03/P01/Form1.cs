/*
 * C# 03, Ex 01
 * 
 * Write a GUI program that accepts the names of three political candidates
 * and the number of votes each received in the last election.  
 * Display the percentage of the total vote that each received.
 * 
 * J. M. Hinckley
 * 2024
 */
namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn1_Click(object sender, EventArgs e)
        {
            // Read in votes
            int vote1 = Convert.ToInt32(votesBox1.Text);
            int vote2 = Convert.ToInt32(votesBox2.Text);
            int vote3 = Convert.ToInt32(votesBox3.Text);
            double factor = 100.0 / (vote1 + vote2 + vote3);

            percentBox1.Text = (vote1 * factor).ToString("F2");
            percentBox2.Text = (vote2 * factor).ToString("F2");
            percentBox3.Text = (vote3 * factor).ToString("F2");
        }
    }
}
