namespace P01_refOutParams
{
    public partial class Form1 : Form
    {
        double ax = 1, ay = 2;
        double bx = 4, by = 5;
        double cx = 6, cy = 1;
        double dx = 3, dy = -1;
        double area = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            ax = Convert.ToDouble(textBoxAx.Text);
            ay = Convert.ToDouble(textBoxAy.Text);
            bx = Convert.ToDouble(textBoxBx.Text);
            by = Convert.ToDouble(textBoxBy.Text);
            cx = Convert.ToDouble(textBoxCx.Text);
            cy = Convert.ToDouble(textBoxCy.Text);
            dx = Convert.ToDouble(textBoxDx.Text);
            dy = Convert.ToDouble(textBoxDy.Text);

            TranslateTriangle(ref ax, ref ay, ref bx, ref by, ref cx, ref cy, dx, dy);

            textBoxTAx.Text = ax.ToString();
            textBoxTAy.Text = ay.ToString();
            textBoxTBx.Text = bx.ToString();
            textBoxTBy.Text = by.ToString();
            textBoxTCx.Text = cx.ToString();
            textBoxTCy.Text = cy.ToString();

        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            CalculateTriangleArea(ax, ay, bx, by, cx, cy, out area);
            textBoxArea.Text = area.ToString();
        }


        // Method to translate the triangle by (dx, dy)
        private void TranslateTriangle(
            ref double ax, ref double ay,
            ref double bx, ref double by,
            ref double cx, ref double cy,
            double dx, double dy)
        {
            ax += dx;
            ay += dy;
            bx += dx;
            by += dy;
            cx += dx;
            cy += dy;
        }

        // Method to calculate the area of the triangle using the shoelace formula
        static void CalculateTriangleArea(
            double ax, double ay, double bx, double by, double cx, double cy,
            out double area)
        {
            area = 0.5 * Math.Abs(
                ax * by + bx * cy + cx * ay -
                (ay * bx + by * cx + cy * ax)
            );
        }
    }
}
