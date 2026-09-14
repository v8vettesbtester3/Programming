namespace P03
{
    public partial class Form1 : Form
    {
        int[] baseVal = { 2, 10, 16 };
        public Form1()
        {
            InitializeComponent();

            InputBaseComboBox.Items.Add(baseVal[0].ToString());
            InputBaseComboBox.Items.Add(baseVal[1].ToString());
            InputBaseComboBox.Items.Add(baseVal[2].ToString());
            OutputBaseComboBox.Items.Add(baseVal[0].ToString());
            OutputBaseComboBox.Items.Add(baseVal[1].ToString());
            OutputBaseComboBox.Items.Add(baseVal[2].ToString());
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            string inputNumString = InputNumberBox.Text;

            int idxInputBase = InputBaseComboBox.SelectedIndex;
            int idxOutputBase = OutputBaseComboBox.SelectedIndex;
            int inputBase = baseVal[idxInputBase];
            int outputBase = baseVal[idxOutputBase];

            string outNumString = "";
            switch (idxInputBase)
            {
                case 0:
                    switch (idxOutputBase)
                    {
                        case 0:     // base 2 -> base 2
                            outputNumLbl.Text = inputNumString;
                            break;
                        case 1:     // base 2 -> base 10
                            outNumString = Translate.Bin2Dec(inputNumString);
                            outputNumLbl.Text = outNumString;
                            break;
                        case 2:     // base 2 -> base 16
                            outNumString = Translate.Bin2Hex(inputNumString);
                            outputNumLbl.Text = outNumString;
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:
                    switch (idxOutputBase)
                    {
                        case 0:     // base 10 -> base 2
                            outNumString = Translate.Dec2Bin(inputNumString);
                            outputNumLbl.Text = outNumString;
                            break;
                        case 1:     // base 10 -> base 10
                            outputNumLbl.Text = inputNumString;
                            break;
                        case 2:     // base 10 -> base 16
                            outNumString = Translate.Dec2Hex(inputNumString);
                            outputNumLbl.Text = outNumString;
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (idxOutputBase)
                    {
                        case 0:     // base 16 -> base 2
                            outNumString = Translate.Hex2Bin(inputNumString);
                            outputNumLbl.Text = outNumString;
                            break;
                        case 1:     // base 16 -> base 10
                            outNumString = Translate.Hex2Dec(inputNumString);
                            outputNumLbl.Text = outNumString;
                            break;
                        case 2:     // base 16 -> base 16
                            outputNumLbl.Text = inputNumString;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;

            }
        }
    }
}
