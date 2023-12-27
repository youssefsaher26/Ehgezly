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
    public partial class Old_Bookings : Form
    {
        Controller controllerObj;
        String ReviewerID;
        String BookingType;
        public Old_Bookings(string ID,string Type)
        {
            InitializeComponent();
            controllerObj=new Controller();

            DataTable dt=null;
            ReviewerID = ID;
            BookingType=Type;
            if (BookingType=="Court")
            {
                 dt = controllerObj.SelectOldPlayerCourtBookings(ReviewerID);
              
            }
            else if(BookingType == "Training")
            {
                 dt = controllerObj.SelectOldPlayertrainingSession(ReviewerID);
               
            }
            else if (BookingType == "maintenance")
            {
                dt = controllerObj.SelectOldmaintenanceBookings(ReviewerID);

            }
            else if (BookingType == "Trainer")
            {
                dt = controllerObj.SelectOldTrainertrainingSession(ReviewerID);

            }
            bookingsgridview.DataSource = dt;
            bookingsgridview.MultiSelect = false;
            bookingsgridview.ReadOnly = true;
            bookingsgridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookingsgridview.Refresh();

        }

        private void bookingsgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void writerev_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(bookingsgridview.SelectedRows[0].Cells[1].Value.ToString())>DateTime.Now)
            {
                MessageBox.Show("You can't review an upcoming booking");
                return;
            }
            if (bookingsgridview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a booking to review!");
                return;
            }

            DataGridViewRow SelectedRow = bookingsgridview.SelectedRows[0];

            review Review = new review(SelectedRow.Cells[0].Value.ToString(), ReviewerID,"Court");
            Review.Show();


          

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (DateTime.Parse(bookingsgridview.SelectedRows[0].Cells[1].Value.ToString()) > DateTime.Now)
            {
                MessageBox.Show("You can't review an upcoming booking");
                return;
            }
            if (bookingsgridview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a booking to review!");
                return;
            }
            DataGridViewRow SelectedRow = bookingsgridview.SelectedRows[0];
            review Review = new review(SelectedRow.Cells[0].Value.ToString(), ReviewerID,"Trainer");
            Review.Show();
        }

        private void Old_Bookings_Load(object sender, EventArgs e)
        {
            if (BookingType== "Training")
            {
                button1.Visible = true;
            }
            else

                button1.Visible = false;
        }
    }
}
