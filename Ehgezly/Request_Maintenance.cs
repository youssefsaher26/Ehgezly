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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ehgezly
{
    public partial class Request_Maintenance : Form
    {
        Controller controllerObj;
        string managerID;
        public Request_Maintenance(string ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            managerID = ID;
            
            DataTable dt = controllerObj.SelectSpecialty();
            comboBox1.DataSource =dt;
            comboBox1.DisplayMember = "Specialty";
            comboBox1.ValueMember = "Specialty";
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void choosespec_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            if(comboBox1.SelectedItem==null)
            { MessageBox.Show("please select a Specialty first");
                return;
            
            }


            dataGridView1.DataSource = controllerObj.SelectMaintenanceWorkers(comboBox1.Text);
            dataGridView1.Refresh();


        }

        private void Request_Maintenance_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            { MessageBox.Show("please select a worker first");
                return;

            }
            controllerObj.AddMaintenanceRequest(managerID, Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value), dateTimePicker1.Value);
        }
    }
}
