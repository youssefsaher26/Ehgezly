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
    public partial class Cancel_Sessions : Form
    {
        Controller controllerObj;
        string email;
        string password;
        public Cancel_Sessions(string pass, string mail)
        {
            InitializeComponent();
            controllerObj = new Controller();
            password = pass;
            email = mail;
            DataTable dt = controllerObj.View_sessions_for_trainer(email,pass);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.Refresh();
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

                    if (controllerObj.DeleteBookings(stringValue) == 1)
                    {
                        MessageBox.Show("Session Deleted");
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
