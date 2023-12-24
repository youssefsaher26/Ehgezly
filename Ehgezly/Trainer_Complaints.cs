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
    public partial class Trainer_Complaints : Form
    {
        Controller controllerObj;
        String AdminID;
        public Trainer_Complaints(String ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            TrainerComplaintgridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TrainerComplaintgridView.MultiSelect = false;
            TrainerComplaintgridView.ReadOnly = true;
            AdminID= ID;
            
        }

        private void TrainerComplaintgridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Trainer_Complaints_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectTrainerComplaints();
            TrainerComplaintgridView.DataSource = dt;
            TrainerComplaintgridView.Refresh();
        }

        private void Openselected_Click(object sender, EventArgs e)
        {

            if(TrainerComplaintgridView.SelectedRows.Count==0)
            {
                MessageBox.Show("Please Select a complaint to open!");
                return;
            }

            DataGridViewRow SelectedRow = TrainerComplaintgridView.SelectedRows[0];


            T_Complaint complaint = new T_Complaint(SelectedRow.Cells[0].Value.ToString(),AdminID);
            complaint.Show();



        }
    }
}
