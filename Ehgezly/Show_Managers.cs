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
    public partial class Show_Managers : Form
    {
        Controller controllerObj;
        public Show_Managers()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectManagers2();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;
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

                    if (controllerObj.DeleteManager(stringValue) == 1)
                    {
                        MessageBox.Show("Manager Deleted");
                        DataTable dt = controllerObj.SelectManagers();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Manager not deleted");
                    }
                }
            }
            else
            {
                MessageBox.Show("please select a row");
            }
        }

        private void updatemanager_Click(object sender, EventArgs e)
        {
            Manager_MyAcc manager_MyAcc =new Manager_MyAcc(Convert.ToString(dataGridView1.SelectedRows[0].Cells[5].Value), Convert.ToString(dataGridView1.SelectedRows[0].Cells[6].Value));
            manager_MyAcc.Show();
        }
    }
}
