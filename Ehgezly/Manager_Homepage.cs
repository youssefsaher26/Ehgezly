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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ehgezly
{
    public partial class Manager_Homepage : Form
    {
        Controller controllerObj;
        string email;
        string pass;
        string managerId;
        public Manager_Homepage(string p, string mail)
        {
            InitializeComponent();
            controllerObj = new Controller();
            pass = p;
            email = mail;
            managerId = controllerObj.GetID(email);

            DataTable dt = controllerObj.SelectCourts();
            Court_name_comboBox1.DataSource = dt;
            Court_name_comboBox1.DisplayMember = "Court_Name";
            Court_name_comboBox1.ValueMember = "Court_ID";

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePicker2.ShowUpDown = true;
        }

        private void Manager_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void oldmnrequests_Click(object sender, EventArgs e)
        {
            Old_Bookings old_Bookings = new Old_Bookings(managerId, "maintenance");
            old_Bookings.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Manager_MyAcc R = new Manager_MyAcc(pass, email);
            R.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = controllerObj.AddAvailableCourtTimeslots(dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm"), dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm"), Court_name_comboBox1.SelectedValue.ToString());

            if (r == 1)
            {
                MessageBox.Show("Available Timeslots is added successfully");
            }
            else if (r != 1)
            {
                MessageBox.Show("failed ! Timeslots is not added");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
