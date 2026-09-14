// From BPA RLC 2021

namespace P01_financeCalculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operatorClicked = "";
        bool isOperatorClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        // Single operator click event
        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Allows a subtotal to appear with secondary operator click.
            //if (resultValue != 0)
            //{
            //    btnEquals.PerformClick();
            //    operatorClicked = button.Text;
            //    isOperatorClicked = true;
            //}
            //else
            //{
            operatorClicked = button.Text;
            resultValue = Double.Parse(outputBox.Text);
            isOperatorClicked = true;
            //}

            //operatorClicked = button.Text;
            //resultValue = Double.Parse(outputBox.Text);
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            switch (operatorClicked)
            {
                case "+":
                    resultValue += Double.Parse(outputBox.Text);
                    outputBox.Text = resultValue.ToString();
                    break;
                case "-":
                    resultValue -= Double.Parse(outputBox.Text);
                    outputBox.Text = resultValue.ToString();
                    break;
                case "X":
                    resultValue *= Double.Parse(outputBox.Text);
                    outputBox.Text = resultValue.ToString();
                    break;
                case "/":
                    resultValue /= Double.Parse(outputBox.Text);
                    outputBox.Text = resultValue.ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            outputBox.Text = "0";
            resultValue = 0;
        }

        // Single event for number buttons; appends their text to the outputBox
        // Limits data entry to only 1 period.
        private void click_btn(object sender, EventArgs e)
        {
            if (outputBox.Text == "0" || isOperatorClicked)
            {
                outputBox.Clear();  // Clear off what's there to make space for new value displayed
            }
            isOperatorClicked = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!outputBox.Text.Contains("."))
                {
                    outputBox.Text = outputBox.Text + ".";
                }
            }
            else
            {
                outputBox.Text = outputBox.Text + button.Text;
            }
        }

        private void btnCalculateInterest(object sender, EventArgs e)
        {
            int compoundType;
            double principle;
            double annualRate;
            int numberPeriods;
            bool principleTRUE, rateTRUE, periodsTRUE;

            if (Double.TryParse(txtDollars.Text,out principle))
            {
                principle = Double.Parse(txtDollars.Text);
                principleTRUE = true;
            }
            else
            {
                MessageBox.Show("Incorrect data entered for principle.", "Incorrect Data Value");
                principleTRUE=false;
            }

            if (Double.TryParse(txtInterest.Text, out annualRate))
            {
                annualRate = Double.Parse(txtInterest.Text) / 100;
                rateTRUE = true;
            }
            else
            {
                MessageBox.Show("Incorrect data entered for interest.", "Incorrect Data Value");
                rateTRUE = false;
            }

            if (Int32.TryParse(txtYears.Text, out numberPeriods))
            {
                numberPeriods = Int32.Parse(txtYears.Text);
                periodsTRUE = true;
            }
            else
            {
                MessageBox.Show("Incorrect data entered for years.", "Incorrect Data Value");
                periodsTRUE = false;
            }

            // Performs calculation for compound interest;
            // will not progress until all data are correct.
            if (principleTRUE && rateTRUE && periodsTRUE)
            {
                if (rdoMonthly.Checked) compoundType = 12;
                else if (rdoQtr.Checked) compoundType = 4;
                else if (rdoSemi.Checked) compoundType = 2;
                else compoundType = 1;

                double i = annualRate / compoundType;
                int n = compoundType * numberPeriods;
                double futureValue = principle * Math.Pow(1 + i, n);
                cmpdOutput.Text = futureValue.ToString("C");
            }
        }
    }
}
