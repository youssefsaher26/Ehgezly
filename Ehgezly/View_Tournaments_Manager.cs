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
    public partial class View_Tournaments_Manager : Form
    {
        Controller controllerObj;
        string managerId;
        public View_Tournaments_Manager(string Id)
        {
            InitializeComponent();
            controllerObj = new Controller();
            managerId= Id;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            DataTable dt = controllerObj.SelectTournamentAtCourt(managerId);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_Tournament update_Tournament = new Update_Tournament(Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value));
            update_Tournament.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controllerObj.DeleteTouranment(Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value));
            DataTable dt = controllerObj.SelectTournamentAtCourt(managerId);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Joined view_Joined = new View_Joined("player", Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value));
            view_Joined.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            View_Joined view_Joined = new View_Joined("trainer", Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value));
            view_Joined.Show();

        }
    }
}
