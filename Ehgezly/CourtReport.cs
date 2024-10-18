using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ehgezly
{
    public partial class CourtReport : Form
    {
        public CourtReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AverageBookings a = new AverageBookings();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AvgTraining a = new AvgTraining();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrackReviews a = new TrackReviews();
            a.Show();
        }
    }
}
