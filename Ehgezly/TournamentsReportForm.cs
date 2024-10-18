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
    public partial class TournamentsReportForm : Form
    {
        public TournamentsReportForm()
        {
            InitializeComponent();
        }

        private void NoPlayersButton_Click(object sender, EventArgs e)
        {
            NumberOfPlayers a = new NumberOfPlayers();
            a.Show();
        }

        private void NoTrainersButton_Click(object sender, EventArgs e)
        {
            NumberOfTrainers a = new NumberOfTrainers();
            a.Show();
        }
    }
}
