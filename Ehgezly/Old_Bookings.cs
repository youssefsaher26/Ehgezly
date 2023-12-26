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
        String PlayerID;
        String BookingType;
        public Old_Bookings(string ID,string Type)
        {
            InitializeComponent();
            controllerObj=new Controller();

            DataTable dt=null;
            PlayerID = ID;
            BookingType=Type;
            if (BookingType=="Court")
            {
                 dt = controllerObj.SelectOldPlayerCourtBookings(PlayerID);
              
            }
            else if(BookingType == "Training")
            {
                 dt = controllerObj.SelectOldPlayertrainingSession(PlayerID);
               
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
            if (bookingsgridview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a booking to review!");
                return;
            }

            DataGridViewRow SelectedRow = bookingsgridview.SelectedRows[0];

            review Review = new review(SelectedRow.Cells[0].Value.ToString(), PlayerID);
            Review.Show();


          

        }
    }
}
