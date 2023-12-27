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
    public partial class review : Form
    {
        Controller controllerObj;
        String BookingID;
        String ReviewerID;
        string reviewType;
        public review(string ID, string RID,string revtype)
        {
            InitializeComponent();
            BookingID = ID;
            ReviewerID = RID;
            controllerObj = new Controller();
            reviewType = revtype;
        }

     

        private void review_Load(object sender, EventArgs e)
        {

        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {

            int rating = 0;
          
            if (radioButton11.Checked) { rating = 1; }
            else if (radioButton21.Checked) { rating = 2; }
            else if (radioButton31.Checked) { rating = 3; }
            else if (radioButton41.Checked) { rating = 4; }
            else if (radioButton51.Checked) { rating = 5; }
            else
            {
                MessageBox.Show("Please select a rating!");

                return;
            }

            string revID =controllerObj.AddRating( rating, BookingID,ReviewerID);
            if(revID==null)
            { MessageBox.Show("You've rated this Before!");
                return;
            }

            if (BookingID.Contains("C"))
            {
                controllerObj.AddCourtReview(revID, controllerObj.GetCourtIDfromBooking(BookingID));
            }
            else if (BookingID.Contains("T"))
            {

                if (ReviewerID.Contains("P"))
                {
                    if(reviewType=="Trainer")
                    controllerObj.AddTrainerReview(revID, controllerObj.GetTrainerIDfromTrainingSession(BookingID));
                    else
                        controllerObj.AddCourtReview(revID, controllerObj.GetCourtIDfromBooking(BookingID));
                }
                else
                {
                    controllerObj.AddCourtReview(revID, controllerObj.GetCourtIDfromBooking(BookingID));

                }


            }
            else if (BookingID.Contains("M"))
            {
                controllerObj.AddMaintenanceReview(revID, controllerObj.GetTrainerIDfromTrainingSession(BookingID));
            }


            if (richTextBox1.Text.Length!=0)
            {
                controllerObj.AddCommentToReview(revID, richTextBox1.Text);
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
