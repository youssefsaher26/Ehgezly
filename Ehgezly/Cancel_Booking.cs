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
    public partial class Cancel_Booking : Form
    {
        Controller controllerObj;
        string email;
        string password;
        public Cancel_Booking(string p, string mail)
        {
            password = p;
            email = mail;
            controllerObj = new Controller();
            InitializeComponent();
            DataTable dt = controllerObj.View_upcoming_boookings(email, password);
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                object selectedValue = selectedRow.Cells[0].Value;
                if (selectedValue != null)
                {
                    string stringValue = selectedValue.ToString();
                    
                    if(controllerObj.DeleteBookings(stringValue)==1) 
                    {
                        MessageBox.Show("Booking Deleted");
                        DataTable dt = controllerObj.View_upcoming_boookings(email, password);
                        dataGridView2.DataSource = dt;
                        dataGridView2.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Booking not deleted");
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
