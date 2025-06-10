using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColocTour
{
    public partial class MainForm : Form
    {
        private List<Tour> tours = new List<Tour>();
        public MainForm()
        {

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            // это пример
            tours.Add(new Tour("Россия", 5, 110000));
            tours.Add(new Tour("Франция", 5, 110000));
            tours.Add(new Tour("Италия", 5, 110000));




            UpdateTourList();
        }
        public void AddTour(Tour tour)
        {
            tours.Add(tour);
            UpdateTourList();

        }

        public void UpdateTourList()
        {
            listBoxTours.Items.Clear();
            foreach (var tour in tours)
            {
                listBoxTours.Items.Add(tour);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBoxMinDays.Text, out int minDays) && int.TryParse(textBoxMaxDays.Text, out int max))
            {
                listBoxTours.Items.Clear();
                foreach(var tour in tours)
                {
                    if(tour.Duration >= minDays && tour.Duration <= max)
                    {
                        listBoxTours.Items.Add(tour);
                    }
                }

                textBoxMinDays.Clear();
                textBoxMaxDays.Clear();
            }
            else
                MessageBox.Show("Введите правильно цифры");
        }

        private void buttonAddTour_Click(object sender, EventArgs e)
        {
            AddTourForm addForm = new AddTourForm(this);
            addForm.Show();
        }
    }
}
