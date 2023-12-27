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
    public partial class Tournaments_Trainer : Form
    {
        Controller controllerObj;
        string password;
        string email;
        public Tournaments_Trainer(string pass,string mail)
        {
            password = pass;
            email = mail;
            InitializeComponent();
            controllerObj = new Controller();
            dataGridView1.DataSource = controllerObj.ViewUpcomingTournaments(email,password);
        }

        private void Tournaments_Trainer_Load(object sender, EventArgs e)
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

                    if (controllerObj.Cancel_Tournament_Particpation(stringValue,email,password) == 1)
                    {
                        MessageBox.Show("Tournament Particpation Cancelled");
                        DataTable dt = controllerObj.View_sessions_for_trainer(email, password);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Session not deleted");
                    }
                }
            }
            else
            {
                MessageBox.Show("please select a row");
            }
        }
    }
}
