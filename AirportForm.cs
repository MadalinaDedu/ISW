using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class AirportForm : Form
    {
        public AirportForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm Pilot = new AdminForm();
            Pilot.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            AirportForm Airport = new AirportForm();
            Airport.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlightForm Flight = new FlightForm();
            Flight.Show();
        }
    }
}
