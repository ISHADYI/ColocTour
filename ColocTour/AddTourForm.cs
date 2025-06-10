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
    public partial class AddTourForm : Form
    {
        private MainForm mainForm;

        public AddTourForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void AddTourForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string country = textBoxCountry.Text;
            if(!int.TryParse(textBoxDuration.Text, out int duration) || !decimal.TryParse(textBoxPrice.Text, out decimal price))
            {
                MessageBox.Show("Неверный формат длительности или цены");
                return;
            }

            Tour newTour = new Tour(country, duration, price);
            mainForm.AddTour(newTour);
            this.Close();
        }

        private void textBoxCountry_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxDuration_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
