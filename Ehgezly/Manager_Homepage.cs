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
            Courtname_comboBox1.DataSource = dt;
            Courtname_comboBox1.DisplayMember = "Court_Name";
            Courtname_comboBox1.ValueMember = "Court_ID";

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

        private void button123456_Click(object sender, EventArgs e)
        {
            Show_Complaints trainerComplaints = new Show_Complaints(managerId);
            trainerComplaints.Show();
        }

        private void button2222_Click(object sender, EventArgs e)
        {
            Request_Maintenance request_Maintenance= new Request_Maintenance(managerId);
            request_Maintenance.Show();

        }

        private void button3333_Click(object sender, EventArgs e)
        {
            if (textBox1111.Text.Length==0)
            {
                MessageBox.Show("Please Add tournament Name");
                return;
            }
            controllerObj.AddNewTournament(managerId, textBox1111.Text, dateTimePicker11111.Value);
        }



        private void button4444_Click(object sender, EventArgs e)
        {
            View_Tournaments_Manager view_Tournaments_Manager = new View_Tournaments_Manager(managerId);
            view_Tournaments_Manager.Show();
        }

    

        private void AddCourt_Click(object sender, EventArgs e)
        {
            int r = controllerObj.AddAvailableCourtTimeslots(dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm"), dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm"), Courtname_comboBox1.SelectedValue.ToString());

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
