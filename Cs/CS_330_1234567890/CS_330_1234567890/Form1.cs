// 1234567890
namespace CS_330_1234567890
{
    public partial class Form1 : Form
    {
        private char op;  // arithmetic operation
        private double num1;    // first and second numbers to be combined in calculator
        private double num2;

        public Form1()
        {
            InitializeComponent();
            op = '\0'; // no operation
            num1 = 0;
            num2 = 0;
        }

        private void click_btn(object sender, EventArgs e)
        {
            if (outputBox.Text.Equals("0")) outputBox.Text = "";
            if (op == '\0') outputBox.Text = "";    // clear previous result
            if ((Button)sender == btnPeriod)
            {
                if (outputBox.Text.Contains('.')) return;
            }
            outputBox.Text += ((Button)sender).Text;
            if (op == '\0')
            {
                // there is no operation, this must be the first number
                num1 = Double.Parse(outputBox.Text);
            }
            else
            {
                // there is an operation pending, this must be the second number
                // get the substring of the output box text starting after the operator
                int pos = outputBox.Text.IndexOf(op);
                num2 = Double.Parse(outputBox.Text.Substring(pos + 1));
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            if (op != '\0')
            {
                // there already is an operation pending
                // carry it out the record new operation
                calculate();
            }
            if ((Button)sender == btnPlus) op = '+';
            if ((Button)sender == btnMinus) op = '-';
            if ((Button)sender == btnMultiply) op = '*';
            if ((Button)sender == btnDivide) op = '/';
            outputBox.Text += op;
        }

        private void calculate()
        {
            switch (op)
            {
                case '+':
                    num1 = num1 + num2;
                    outputBox.Text = num1.ToString();
                    break;
                case '-':
                    num1 = num1 - num2;
                    outputBox.Text = num1.ToString();
                    break;
                case '*':
                    num1 = num1 * num2;
                    outputBox.Text = num1.ToString();
                    break;
                case '/':
                    num1 = num1 / num2;
                    outputBox.Text = num1.ToString();
                    break;
            }
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            calculate();
            op = '\0';  // clear the pending operation
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            op = '\0';
            outputBox.Text = "0";
        }

        private void btnCalculateInterest(object sender, EventArgs e)
        {
            int compoundType = 0;
            double principle = 0;
            double annualRate = 0;
            int numberYears = 0;
            bool principleOK = false, rateOK = false, yearsOK = false;

            // Input from text boxes, check validity
            // Principle
            if (double.TryParse(txtDollars.Text, out principle))
            {
                principleOK = true;
            }
            else
            {
                principleOK = false;
                MessageBox.Show("Incorrect data entered for inital dollar amount.", "Incorrect Data Value");
            }

            // Annual Rate
            if (double.TryParse(txtInterest.Text, out annualRate))
            {
                annualRate /= 100;  // percent input, convert to fraction.
                rateOK = true;
            }
            else
            {
                rateOK = false;
                MessageBox.Show("Incorrect data entered for interest.", "Incorrect Data Value");
            }

            // Number of years
            if (int.TryParse(txtYears.Text, out numberYears))
            {
                yearsOK = true;
            }
            else
            {
                yearsOK = false;
                MessageBox.Show("Incorrect data entered for years.", "Incorrect Data Value");
            }

            // Do calculation of compound interest if all OK
            if (principleOK && rateOK && yearsOK)
            {
                // number of compoundings
                if (rdoMonthly.Checked) compoundType = 12;
                else if (rdoQtr.Checked) compoundType = 4;
                else if (rdoSemi.Checked) compoundType = 2;
                else compoundType = 1;

                double interest = annualRate / compoundType;        // interest per compounding cycle
                int numCompoundings = compoundType * numberYears;   // number of compounding cycles
                double futureValue = principle * Math.Pow(1 + interest, numCompoundings);
                cmpdOutput.Text = futureValue.ToString("C");
            }
        }
    }
}

