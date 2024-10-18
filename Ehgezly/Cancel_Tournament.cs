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
    public partial class Cancel_Tournament : Form
    {
        Controller controllerObj;
        string email;
        string password;
        public Cancel_Tournament(string mail, string pass)
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.ViewUpcomingTournaments2(mail, pass);
            Canceltourgridview.DataSource = dt;
            Canceltourgridview.ReadOnly = true;
            Canceltourgridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Canceltourgridview.MultiSelect = false;
            Canceltourgridview.ReadOnly = true;
            Canceltourgridview.Refresh();
            email = mail;
            password = pass;
        }

        private void Canceltour_Click(object sender, EventArgs e)
        {
            if (Canceltourgridview.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = Canceltourgridview.SelectedRows[0];

                object selectedValue = selectedRow.Cells[0].Value;
                if (selectedValue != null)
                {
                    string stringValue = selectedValue.ToString();

                    if (controllerObj.Cancel_Tournament_Particpation(stringValue, email, password) == 1)
                    {

                        MessageBox.Show("Tournament Particpation Cancelled");
                        DataTable dt = controllerObj.ViewUpcomingTournaments2(email, password);
                        Canceltourgridview.DataSource = dt;
                        Canceltourgridview.ReadOnly = true;
                        Canceltourgridview.Refresh();
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
    }


}
