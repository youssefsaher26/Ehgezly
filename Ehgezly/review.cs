﻿using DBapplication;
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
        public review(string ID, string RID)
        {
            InitializeComponent();
            BookingID = ID;
            ReviewerID = RID;
            controllerObj = new Controller();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void review_Load(object sender, EventArgs e)
        {

        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {

            int rating = 0;
          
            if (radioButton1.Checked) { rating = 1; }
            else if (radioButton2.Checked) { rating = 2; }
            else if (radioButton2.Checked) { rating = 2; }
            else if (radioButton3.Checked) { rating = 3; }
            else if (radioButton4.Checked) { rating = 4; }
            else if (radioButton5.Checked) { rating = 5; }
            else
            {
                MessageBox.Show("Please select a rating!");

                return;
            }

            string revID =controllerObj.AddRating( rating, BookingID,ReviewerID);

            if (BookingID.Contains("TR"))
            {
                controllerObj.AddCourtReview(revID, controllerObj.GetCourtIDfromBooking(BookingID));
            }
            else if (BookingID.Contains("C"))
            {
                controllerObj.AddTrainerReview(revID, controllerObj.GetTrainerIDfromTrainingSession(BookingID));
            }
            else if (BookingID.Contains("M"))
            {
                controllerObj.AddTrainerReview(revID, controllerObj.GetTrainerIDfromTrainingSession(BookingID));
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
