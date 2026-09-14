namespace P02_parameterArray
{
    public partial class Form1 : Form
    {
        struct DPoint
        {
            public double x;
            public double y;
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenPath_Click(object sender, EventArgs e)
        {
            string s = textBoxInputs.Text;

            double[] vals = s.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries) // Split by space
                             .Select(double.Parse) // Convert each element to double
                             .ToArray(); // Convert to an array
            DPoint[] points = new DPoint[vals.Length / 2];
            for (int i = 0; i < vals.Length; i += 2)
            {
                points[i / 2].x = vals[i];
                points[i / 2].y = vals[i + 1];
            }

            double pathLength = CalculatePerimeter(false, points);
            textBoxOpenPL.Text = pathLength.ToString();
        }

        // Method to calculate perimeter using params array of points
        static double CalculatePerimeter(bool isClosed, params DPoint[] vertices)
        {
            double perimeter = 0;

            if (vertices.Length > 0)
            {
                // Loop through each pair of consecutive vertices
                for (int i = 0; i < vertices.Length - 1; i++)
                {
                    // Get the current and next vertex (wrap around to the first)
                    double x1 = vertices[i].x;
                    double y1 = vertices[i].y;
                    double x2 = vertices[i + 1].x;
                    double y2 = vertices[i + 1].y;

                    // Calculate the distance between the two points
                    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                    perimeter += distance;
                }

                if (isClosed)
                {
                    // Calculate the closing segment length and add to perimeter value.
                    double x1 = vertices[vertices.Length - 1].x;
                    double y1 = vertices[vertices.Length - 1].y;
                    double x2 = vertices[0].x;
                    double y2 = vertices[0].y;

                    // Calculate the distance between the two points
                    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                    perimeter += distance;
                }
            }
            else
            {
                perimeter = 0;
            }

            return perimeter;
        }

        private void buttonClosedPath_Click(object sender, EventArgs e)
        {
            string s = textBoxInputs.Text;

            double[] vals = s.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries) // Split by space
                             .Select(double.Parse) // Convert each element to double
                             .ToArray(); // Convert to an array
            DPoint[] points = new DPoint[vals.Length / 2];
            for (int i = 0; i < vals.Length; i += 2)
            {
                points[i / 2].x = vals[i];
                points[i / 2].y = vals[i + 1];
            }

            double pathLength = CalculatePerimeter(true, points);
            textBoxClosedPL.Text = pathLength.ToString();
        }
    }
}
