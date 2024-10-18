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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ehgezly
{
    public partial class Show_Tournament : Form
    {
        Controller controllerObj;
        string email;
        string password;
        public Show_Tournament(string mail, string pass)
        {
            InitializeComponent();
            controllerObj = new Controller();
            email = mail;
            password = pass;
        }

        private void Show_Tournament_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewUpcomingTournaments();
            dataGridView1.DataSource = dt;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                object selectedValue = selectedRow.Cells[0].Value;
                if (selectedValue != null)
                {
                    string stringValue = selectedValue.ToString();

                    if (controllerObj.AddPlayertoTournmaent(stringValue, email, password) == 1)
                    {

                        MessageBox.Show("Tournament Joined");
                    }
                    else
                    {
                        MessageBox.Show("Tournament already joined");
                    }
                }
            }
        }
    }
}
