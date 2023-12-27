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
    public partial class Show_Complaints : Form
    {
        Controller controllerObj;
        String ReviewerID;
        public Show_Complaints(String ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            TrainerComplaintgridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TrainerComplaintgridView.MultiSelect = false;
            TrainerComplaintgridView.ReadOnly = true;
            ReviewerID = ID;
            
        }

        private void TrainerComplaintgridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Trainer_Complaints_Load(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (ReviewerID.StartsWith("M"))
            {
                dt = controllerObj.SelectCourtComplaints();
            }
            else if (ReviewerID.StartsWith("A"))
            { dt = controllerObj.SelectTrainerComplaints(); }
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


            Review_Complaint complaint = new Review_Complaint(SelectedRow.Cells[0].Value.ToString(),ReviewerID);
            complaint.Show();



        }
    }
}
