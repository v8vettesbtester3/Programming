/*
 C# 09, Ex 03

This exercise requires the declaration and instantiation of an array of objects.  
Create a C# GUI program that allows the user to enter the coordinates of several 
spheres and determines which of them overlap.

To model the spheres, create a Sphere class.  This should have auto-implemented 
properties for the coordinates of the center of the sphere (all double) and the
radius of the sphere (also double).  
The class should have a constructor that takes four arguments, radius, x, y, z.  

Add a boolean method that takes a Sphere object as a parameter and returns true 
if that Sphere and this one overlap but do not touch. 
Use the Pythagorean theorem to determine if they overlap by comparing the 
distance between the two sphere’s centers to the sum of their radii.

Add a second boolean method takes a Sphere object as a parameter and 
returns true if that Sphere and this one touch.  
Determine touching to be true if the difference between the surfaces 
of the spheres is less than 0.001.

J. M. Hinckley
2024
 */
namespace P03_arrayObjects
{

    public class Sphere
    {
        public double Radius { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Sphere(double radius, double x, double y, double z)
        {
            Radius = radius;
            X = x;
            Y = y;
            Z = z;
        }

        public bool doesOverlap(Sphere otherSphere)
        {
            double distance = Math.Sqrt(
                Math.Pow(X - otherSphere.X, 2) +
                Math.Pow(Y - otherSphere.Y, 2) +
                Math.Pow(Z - otherSphere.Z, 2)
                );

            double minSeparation = Math.Abs(Radius + otherSphere.Radius);

            return distance <= minSeparation && !doesTouch(otherSphere);
        }

        public bool doesTouch(Sphere otherSphere)
        {
            double distance = Math.Sqrt(
                Math.Pow(X - otherSphere.X, 2) +
                Math.Pow(Y - otherSphere.Y, 2) +
                Math.Pow(Z - otherSphere.Z, 2)
                );

            double minSeparation = Math.Abs(Radius + otherSphere.Radius);

            return Math.Abs(distance - minSeparation) <= 0.001;
        }
    }

    public partial class Form1 : Form
    {
        int NumSpheres { get; set; }
        Sphere[]? spheres = null;

        public Form1()
        {
            InitializeComponent();
            numericUpDownSphereIndex.Minimum = 0;
            numericUpDownSphereIndex.Value = numericUpDownSphereIndex.Minimum;
            numericUpDownSphereIndex.Enabled = false;

            txtX.Enabled = false;
            txtY.Enabled = false;
            txtZ.Enabled = false;
            txtR.Enabled = false;
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            // Initialize button pressed.
            // Read the number of spheres
            // Set the sphere number text box and this button disabled.
            // Initialize an array of Sphere objects.
            NumSpheres = int.Parse(txtNumSpheres.Text);
            txtNumSpheres.Enabled = false;
            btnInit.Enabled = false;
            spheres = new Sphere[NumSpheres];
            for (int i = 0; i < spheres.Length; i++)
            {
                spheres[i] = new Sphere(0, 0, 0, 0);
            }



            numericUpDownSphereIndex.Enabled = true;
            numericUpDownSphereIndex.Maximum = spheres.Length - 1;
            int currentIndex = (int)numericUpDownSphereIndex.Minimum;
            numericUpDownSphereIndex.Value = currentIndex;

            txtX.Enabled = true;
            txtY.Enabled = true;
            txtZ.Enabled = true;
            txtR.Enabled = true;

            txtX.Text = spheres[currentIndex].X.ToString();
            txtY.Text = spheres[currentIndex].Y.ToString();
            txtZ.Text = spheres[currentIndex].Z.ToString();
            txtR.Text = spheres[currentIndex].Radius.ToString();

            updateList(currentIndex);
        }


        private void updateList(int selIdx = -1)
        {
            if (spheres != null)
            {
                listBoxSpheres.Items.Clear();
                for (int i = 0; i < spheres.Length; i++)
                {
                    string msg;
                    if (i == selIdx)
                    {
                        msg = $"> ID: {i} (x,y,z): ({spheres[i].X}, {spheres[i].Y}, {spheres[i].Z})  R: {spheres[i].Radius}";
                    }
                    else
                    {
                        msg = $"  ID: {i} (x,y,z): ({spheres[i].X}, {spheres[i].Y}, {spheres[i].Z})  R: {spheres[i].Radius}";
                    }

                    for (int j = 0; j < spheres.Length; j++)
                    {
                        if (j == i) continue;
                        if (spheres[i].doesOverlap(spheres[j]))
                        {
                            msg += $" OVERLAPS sphere {j}";
                        }
                        if (spheres[i].doesTouch(spheres[j]))
                        {
                            msg += $" TOUCHES sphere {j}";
                        }
                    }
                    listBoxSpheres.Items.Add(msg);
                }
            }
        }

        private void numericUpDownSphereIndex_ValueChanged(object sender, EventArgs e)
        {
            int currentIndex = (int)numericUpDownSphereIndex.Value;

            if (spheres != null && currentIndex < spheres.Length)
            {
                txtX.Text = spheres[currentIndex].X.ToString();
                txtY.Text = spheres[currentIndex].Y.ToString();
                txtZ.Text = spheres[currentIndex].Z.ToString();
                txtR.Text = spheres[currentIndex].Radius.ToString();

                updateList(currentIndex);
            }

        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            int currentIndex = (int)numericUpDownSphereIndex.Value;
            if (spheres != null && currentIndex < spheres.Length)
            {
                double r;
                bool success = double.TryParse(txtR.Text, out r);
                if (success)
                {
                    spheres[currentIndex].Radius = Math.Abs(r);
                    updateList(currentIndex);
                }
            }
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {
            int currentIndex = (int)numericUpDownSphereIndex.Value;
            if (spheres != null && currentIndex < spheres.Length)
            {
                double x;
                bool success = double.TryParse(txtX.Text, out x);
                if (success)
                {
                    spheres[currentIndex].X = x;
                    updateList(currentIndex);
                }
            }
        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {
            int currentIndex = (int)numericUpDownSphereIndex.Value;
            if (spheres != null && currentIndex < spheres.Length)
            {
                double y;
                bool success = double.TryParse(txtY.Text, out y);
                if (success)
                {
                    spheres[currentIndex].Y = y;
                    updateList(currentIndex);
                }
            }
        }

        private void txtZ_TextChanged(object sender, EventArgs e)
        {
            int currentIndex = (int)numericUpDownSphereIndex.Value;
            if (spheres != null && currentIndex < spheres.Length)
            {
                //spheres[currentIndex].Z = double.Parse(txtZ.Text);
                double z;
                bool success = double.TryParse(txtZ.Text, out z);
                if (success)
                {
                    spheres[currentIndex].Z = z;
                    updateList(currentIndex);
                }

            }
        }
    }
 }
