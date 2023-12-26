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
    public partial class T_Complaint : Form
    {
        Controller controllerObj;
        String ComplaintID;
        String AdminID;
        public T_Complaint(String CID,String AID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            ComplaintID = CID;
            AdminID = AID;


        }

        private void T_Complaint_Load(object sender, EventArgs e)
        {

            DataTable dt = controllerObj.SelectSpecTrainerComplaints(ComplaintID);
            TrainerComplaintgridView.DataSource = dt;
            TrainerComplaintgridView.ReadOnly = true;
            TrainerComplaintgridView.Refresh();
            

        }

        private void TrainerComplaintgridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MarkRev_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length==0)
            {
                MessageBox.Show("please write the action taken towards this ccomplaint.");
                return;
            }
            controllerObj.MarkTrainerComplaintReviewed(ComplaintID);
            controllerObj.AddAdminDetailsToComplaint(richTextBox1.Text,ComplaintID);
            MessageBox.Show("Marked As Reviewd.");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
