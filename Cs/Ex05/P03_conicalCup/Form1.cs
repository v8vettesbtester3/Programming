namespace P03_conicalCup
{
    public partial class Form1 : Form
    {

        double removedSectorLength;
        double waxedPaperRad;
        double paperCupBaseRad; //r
        double paperCupHeight; //h
        double paperCupVol;
        double waxedPaperCircum;
        double maxVolume;
        double cupRadiusAtMaxV = 0;
        double cupHeightAtMaxV = 0;

        double x;
        const double PI = 3.141592654;

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal val = numericUpDown1.Value;
            double dval = (double)val;

            waxedPaperRad = Convert.ToDouble(RadiustextBox.Text);

            x = dval;
            maxVolume = 0.0;
            removedSectorLength = 0.0;
            waxedPaperCircum = 2 * PI * waxedPaperRad;



            //while (x <= waxedPaperCircum)
            {
                paperCupBaseRad = waxedPaperRad - (x / (2 * PI));
                paperCupHeight = Math.Sqrt(waxedPaperRad * waxedPaperRad - paperCupBaseRad * paperCupBaseRad);

                paperCupVol = (1.0 / 3.0) * PI * (paperCupBaseRad * paperCupBaseRad) * paperCupHeight;

                //if (paperCupVol > maxVolume)
                {
                    maxVolume = paperCupVol;
                    cupRadiusAtMaxV = paperCupBaseRad;
                    cupHeightAtMaxV = paperCupHeight;
                    removedSectorLength = x;
                }

                //x = x + 0.01;
            }

            // Code modification 2509260958: fixed bug: arguments of Atan2 were backwards
            double halfAngleRadians = Math.Atan2(cupRadiusAtMaxV, cupHeightAtMaxV);
            double angleDegrees = 2.0 * halfAngleRadians * 180.0 / PI;


            numericUpDown1.Value = (decimal)removedSectorLength;
            ApexAngletextBox.Text = angleDegrees.ToString("F2");
            ConeVoltextBox.Text = maxVolume.ToString("F2");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            waxedPaperRad = Convert.ToDouble(RadiustextBox.Text);

            x = 0.00;
            maxVolume = 0.0;
            removedSectorLength = 0.0;
            waxedPaperCircum = 2 * PI * waxedPaperRad;



            while (x <= waxedPaperCircum)
            {
                paperCupBaseRad = waxedPaperRad - (x / (2 * PI));
                paperCupHeight = Math.Sqrt(waxedPaperRad * waxedPaperRad - paperCupBaseRad * paperCupBaseRad);

                paperCupVol = (1.0 / 3.0) * PI * (paperCupBaseRad * paperCupBaseRad) * paperCupHeight;

                if (paperCupVol > maxVolume)
                {
                    maxVolume = paperCupVol;
                    cupRadiusAtMaxV = paperCupBaseRad;
                    cupHeightAtMaxV = paperCupHeight;
                    removedSectorLength = x;
                }

                x = x + 0.01;
            }

            // Code modification 2509260958: fixed bug: arguments of Atan2 were backwards
            double halfAngleRadians = Math.Atan2(cupRadiusAtMaxV, cupHeightAtMaxV);
            double angleDegrees = 2.0 * halfAngleRadians * 180.0 / PI;


            numericUpDown1.Value = (decimal)removedSectorLength;
            ApexAngletextBox.Text = angleDegrees.ToString("F2");
            ConeVoltextBox.Text = maxVolume.ToString("F2");

        }
    }
}
