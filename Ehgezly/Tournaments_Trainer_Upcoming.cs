using DBapplication;
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
    public partial class Tournaments_Trainer_Upcoming : Form
    {

        string password;
        string email;
        Controller controllerObj;
        public Tournaments_Trainer_Upcoming(string pass, string mail)
        {
            InitializeComponent();
            password = pass;
            email = mail;
            controllerObj = new Controller();

            tournamenttrainingaupcominggridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tournamenttrainingaupcominggridview.MultiSelect = false;
            tournamenttrainingaupcominggridview.ReadOnly = true;
            tournamenttrainingaupcominggridview.DataSource = controllerObj.ViewUpcomingTournaments();
        }
        private void Tournaments_Trainer_Upcoming_Load(object sender, EventArgs e)
        {

        }

        private void tournamenttrainingaupcominggridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void jointournamenttrainer_Click(object sender, EventArgs e)
        {
            controllerObj.AddTrainertoTournmaent(Convert.ToString(tournamenttrainingaupcominggridview.SelectedRows[0].Cells[0].Value), email, password);
        }
    }
}
