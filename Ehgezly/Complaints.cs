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
            dataGridView14143.DataSource = dt;
            dataGridView14143.MultiSelect = false;
            dataGridView14143.ReadOnly = true;
            dataGridView14143.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView14143.Refresh();


        }

    
        private void Complaints_Load(object sender, EventArgs e)
        {

        }



  

        private void button35534_Click(object sender, EventArgs e)
        {
            if (richTextBox1392.Text.Length == 0)
            {
                MessageBox.Show("Please write a comment about your complaint");
            }

            controllerObj.AddComplaint(richTextBox1392.Text, dataGridView14143.SelectedRows[0].Cells[0].Value.ToString(), CpWriterID, type);

        }

        private void dataGridView14143_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
