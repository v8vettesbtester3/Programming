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
                num2 = Double.Parse(outputBox.Text.Substring(pos+1));
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
    }
}

