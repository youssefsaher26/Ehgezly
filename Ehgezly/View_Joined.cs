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
    public partial class View_Joined : Form
    {
        Controller controllerobj;
        string jointype,TournamentId;

        public View_Joined(string type,string tourId)
        {
            InitializeComponent();
            jointype = type;
            TournamentId = tourId;
            controllerobj = new Controller();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            DataTable dt = null;
            if (type=="trainer")
            { dt = controllerobj.SelecttrainersJoined(TournamentId);  }
            if (type == "player")
            {  dt = controllerobj.SelectPlayersJoined(TournamentId); }


            dataGridView1.DataSource= dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int test =0 ;
            if (jointype == "trainer")
            { test = controllerobj.DeleteTrainerJoined(TournamentId, Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value)); }
            if (jointype == "player")
            { test = controllerobj.DeletePlayerJoined(TournamentId, Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value)); }

            if (test > 0)
            {
                MessageBox.Show(jointype + " rejected");
             
            }
            else
            {   MessageBox.Show("Couldn't reject " + jointype);}
            DataTable dt = null;
            if (jointype == "trainer")
            { dt = controllerobj.SelecttrainersJoined(TournamentId); }
            if (jointype == "player")
            { dt = controllerobj.SelectPlayersJoined(TournamentId); }


            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();    


        }
    }
}
