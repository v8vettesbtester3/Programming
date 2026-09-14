/*
 C# 05, Ex 02

The population of town A is less than the population of town B.  
However, the population of town A is growing faster than the population of town B. 
Write a GUI C# program that prompts the user to enter the population and growth 
rate (in percent) of each town.  

The program should output how many years are required for the population of
town A to be greater than that of town B, and what the populations of the
two towns are at that time. 

Add a NumericUpDown control to the GUI and program this so that when the 
above calculation is done, the value in the up-down control is set equal 
to the number of years.  

Furthermore, program the up-down control so that when its value is changed, 
the future populations of towns A and B are recalculated for the number
of years shown in the up-down control.

J. M. Hinckley
2024
 */

namespace P02_popGrowth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal val = numericUpDown1.Value;
            calcShowPopulations((int)val);
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            int numYears = getCrossingYears();
            numericUpDown1.Value = numYears;
            calcShowPopulations(numYears);
        }

        private void calcShowPopulations(int numYears)
        {
            int townAPop = Convert.ToInt32(popAtxtBox.Text);
            double growthRateTownA = Convert.ToDouble(rateAtxtBox.Text);
            int townBPop = Convert.ToInt32(popBtxtBox.Text);
            double growthRateTownB = Convert.ToDouble(rateBtxtBox.Text);

            for (int i = 0; i < numYears; i++)
            {
                townAPop = (int)(townAPop * (1 + 0.01 * growthRateTownA));
                townBPop = (int)(townBPop * (1 + 0.01 * growthRateTownB));
            }

            futurepopAtxtBox.Text = townAPop.ToString();
            futurepopBtxtBox.Text = townBPop.ToString();
        }

        private int getCrossingYears()
        {
            int numYears = 0;
            int townAPop = Convert.ToInt32(popAtxtBox.Text);
            double growthRateTownA = Convert.ToDouble(rateAtxtBox.Text);
            int townBPop = Convert.ToInt32(popBtxtBox.Text);
            double growthRateTownB = Convert.ToDouble(rateBtxtBox.Text);

            while (townAPop < townBPop)
            {
                townAPop = (int)(townAPop * (1 + 0.01 * growthRateTownA));
                townBPop = (int)(townBPop * (1 + 0.01 * growthRateTownB));
                numYears++;
            }

            return numYears;
        }
    }
}
