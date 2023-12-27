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
    public partial class Review_Complaint : Form
    {
        Controller controllerObj;
        String ComplaintID;
        String ReviewerID;
        public Review_Complaint(String CID,String RID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            ComplaintID = CID;
            ReviewerID = RID;



        }

        private void T_Complaint_Load(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (ReviewerID.StartsWith("M"))
            {
                dt = controllerObj.SelectSpecCourtComplaints(ComplaintID);
            }
            else if (ReviewerID.StartsWith("A"))
            { dt = controllerObj.SelectSpecTrainerComplaints(ComplaintID); }
           
            TrainerComplaintgridView.DataSource = dt;
            TrainerComplaintgridView.ReadOnly = true;
            TrainerComplaintgridView.Refresh();
            

        }

        private void TrainerComplaintgridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

    

        private void MarkRev_Click(object sender, EventArgs e)
        {
            if (richTextBox15.Text.Length==0)
            {
                MessageBox.Show("please write the action taken towards this ccomplaint.");
                return;
            }
            controllerObj.MarkComplaintReviewed(ComplaintID);
            controllerObj.AddReviewerDetailsToComplaint(richTextBox15.Text,ComplaintID);
            MessageBox.Show("Marked As Reviewd.");


        }

   

       
    }
}
