namespace P01_temperatureVar
{
    public partial class Form1 : Form
    {
        double[] temperature = { 0, 0, 0, 0, 0 };

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = temperature[0].ToString();
            textBox2.Text = temperature[1].ToString();
            textBox3.Text = temperature[2].ToString();
            textBox4.Text = temperature[3].ToString();
            textBox5.Text = temperature[4].ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            enableInput(1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            enableInput(2);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            enableInput(3);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            enableInput(4);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            enableInput(5);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            temperature[0] = Convert.ToDouble(textBox1.Text);
            textBox6.Text = calculateTrend();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            temperature[1] = Convert.ToDouble(textBox2.Text);
            textBox6.Text = calculateTrend();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            temperature[2] = Convert.ToDouble(textBox3.Text);
            textBox6.Text = calculateTrend();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            temperature[3] = Convert.ToDouble(textBox4.Text);
            textBox6.Text = calculateTrend();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            temperature[4] = Convert.ToDouble(textBox5.Text);
            textBox6.Text = calculateTrend();
        }

        private string calculateTrend()
        {
            string retStr = "";
            bool ascending = true;
            bool descending = true;

            for (int i = 0; i < 4; i++)
            {
                if (temperature[i] >= temperature[i + 1]) ascending = false;
                if (temperature[i] <= temperature[i + 1]) descending = false;
            }
            if (ascending) retStr = "Getting warmer.";
            else if (descending) retStr = "Getting cooler.";
            else retStr = "It's a mixed bag.";
            return retStr;
        }

        private void enableInput(int num)
        {
            textBox1.Enabled = false;
            textBox1.BackColor = Color.LightGray;
            textBox2.Enabled = false;
            textBox2.BackColor = Color.LightGray;
            textBox3.Enabled = false;
            textBox3.BackColor = Color.LightGray;
            textBox4.Enabled = false;
            textBox4.BackColor = Color.LightGray;
            textBox5.Enabled = false;
            textBox5.BackColor = Color.LightGray;
            switch (num)
            {
                case 1:
                    textBox1.Enabled=true;
                    textBox1.BackColor = Color.LightGreen;
                    break;
                case 2:
                    textBox2.Enabled = true;
                    textBox2.BackColor = Color.LightGreen;
                    break;
                case 3:
                    textBox3.Enabled = true;
                    textBox3.BackColor = Color.LightGreen;
                    break;
                case 4:
                    textBox4.Enabled = true;
                    textBox4.BackColor = Color.LightGreen;
                    break;
                case 5:
                    textBox5.Enabled = true;
                    textBox5.BackColor = Color.LightGreen;
                    break;
            }
        }
    }
}
