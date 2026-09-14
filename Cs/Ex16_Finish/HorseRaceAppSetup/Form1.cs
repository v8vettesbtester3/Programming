// BPA RLC 2023

using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRaceAppSetup
{
    public partial class Form1 : Form
    {
        List<Horse> horses = new List<Horse>();


        //Horse Names: use these to create your race horses
        string[] names = { "Bella", "Sugar", "Alex", "Alexia", "Lady", "Tucker", "Fancy",
            "Cash", "Dakota", "Daisy", "Spirit", "Cisco", "Annie", "Buddy", "Chance",
            "Dallas", "Star", "Scout", "Lucky", "LadyBug", "Stinky", "Cricket", "Magic",
            "Red", "Bruno", "Sunshine", "Storm", "Rose", "Storm", "Cloud" };
 

        //Student Point    
        private void setHorse()
        {
            var rand = new Random();
            for (int i = 0; i<10; i++)
            {
                Horse h = new Horse(names[rand.Next(names.Length)], rand.Next(100));
                horses.Add(h);
            }
        }
        //Given by VS. 
        public Form1()
        {
            InitializeComponent();
        }
        //This method runs when the form starts 
        private void Form1_Load(object sender, EventArgs e)
        {
            btnMax.Enabled = false;
            btnMin.Enabled = false;
            btnAddHorse.Enabled = false;
            txtName.Enabled = false;
            txtNumber.Enabled = false;
        }

        
        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int i = 1;
            setHorse();
            foreach(Horse h in horses)
            {
                listHorses1.Items.Add(i+") "+h.getHorseInfo());
                i++;
            }
            btnMax.Enabled = true;
            btnMin.Enabled = true;
            btnAddHorse.Enabled = true;
            btnCreate.Enabled = false;
            txtName.Enabled = true;
            txtNumber.Enabled = true;
        }
        
        //Student Point
        private void btnMax_Click(object sender, EventArgs e)
        {
            int ind = 0, num = 0;
            for (int i = 1; i < horses.Count; i++)
            {
                if (horses.ElementAt(i).getNumber() > horses.ElementAt(ind).getNumber())
                {
                    ind = i;
                    num = horses.ElementAt(ind).getNumber();
                }
            }
           lblMax.Text = horses.ElementAt(ind).getNumber().ToString();
        } 

        //Student Point
        private void btnMin_Click(object sender, EventArgs e)
        {
            int ind = 0, num = 0;
            for (int i = 1; i < horses.Count; i++)
            {
                if (horses.ElementAt(i).getNumber() < horses.ElementAt(ind).getNumber())
                {
                    ind = i;
                    num = horses.ElementAt(ind).getNumber();
                }
            }
            lblMin.Text = horses.ElementAt(ind).getNumber().ToString();
        }

        //Student Point x3
        private void btnAddHorse_Click(object sender, EventArgs e)
        {
            int temp = 0;
            bool result = int.TryParse(txtNumber.Text, out temp);
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtNumber.Text))
            {
                MessageBox.Show("Please enter in a name and number");
                txtName.Clear();
                txtNumber.Clear();
                txtName.Focus();
            }
            else if (!result || temp < 0)
            {
                MessageBox.Show("Please enter a whole number for the horse #");
                txtNumber.Clear();
                txtNumber.Focus();
            }
            else
            {
                listHorses1.Items.Clear();
                Horse userHorse = new Horse(txtName.Text, int.Parse(txtNumber.Text));
                horses.Add(userHorse);
                int i = 1;
                foreach (Horse h in horses)
                {
                    listHorses1.Items.Add(i + ") " + h.getHorseInfo().ToString());
                    i++;
                }
                txtName.Clear();
                txtNumber.Clear();
            }
        }
    }
}
