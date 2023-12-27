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
    public partial class Cancel_Tournament : Form
    {
        Controller controllerObj;
        string email;
        string password;
        public Cancel_Tournament(string mail, string pass)
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.ViewUpcomingTournaments(mail,pass);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.Refresh();
            email = mail;
            password = pass;
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

                    if (controllerObj.Cancel_Tournament_Particpation(stringValue, email, password) == 1)
                    {

                        MessageBox.Show("Tournament Particpation Cancelled");
                        DataTable dt = controllerObj.ViewUpcomingTournaments(email, password);
                        dataGridView1.DataSource = dt;
                        dataGridView1.ReadOnly = true;
                        dataGridView1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Tournament not withdrawn");
                    }
                }
            }
            else
            {
                MessageBox.Show("please select a row");
            }
        }

        private void Cancel_Tournament_Load(object sender, EventArgs e)
        {

        } 
    }
}
