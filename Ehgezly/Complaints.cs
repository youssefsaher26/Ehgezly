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
    public partial class Complaints : Form
    {
        string CpWriterID;
        Controller controllerObj;
        string type;
        public Complaints(string ID, string CPtype)
        {
            InitializeComponent();
            controllerObj = new Controller();
            CpWriterID = ID;
            DataTable dt = null;
            if (CPtype == "Court")
            {
                dt = controllerObj.SelectOldPlayerCourtBookings(ID);

            }
            else if (CPtype == "Trainer")
            {
                dt = controllerObj.SelectOldPlayertrainingSession(ID);

            }
            else if (CPtype == "FromTrainer")
            {
                dt = controllerObj.SelectOldTrainertrainingSession(ID);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Refresh();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Complaints_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length==0)
            {
                MessageBox.Show("Please write a comment about your complaint");
            }
           
            controllerObj.AddComplaint(richTextBox1.Text, dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), CpWriterID, type);
        }
    }
}
