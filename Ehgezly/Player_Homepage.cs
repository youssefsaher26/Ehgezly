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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Security.Cryptography;

namespace Ehgezly
{
    public partial class Player_Homepage : Form
    {
        Controller controllerObj;
        Controller controllerObj2;
        Controller controllerObj3;

        string email;
        string pass;

        public Player_Homepage(string p,string mail)
        {
            InitializeComponent();
            controllerObj = new Controller();
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.SelectedIndex = 0;

            DataTable dt = controllerObj.SelectCourt(comboBox2.SelectedIndex);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Court_Location";
            comboBox1.ValueMember = "Court_Location";

            controllerObj2 = new Controller();
            DataTable dt1 = controllerObj2.SelectCourtname(comboBox1.SelectedValue.ToString());
            comboBox3.DataSource = dt1;
            comboBox3.DisplayMember = "Court_Name";
            comboBox3.ValueMember = "Court_ID";

            controllerObj3 = new Controller();
            DataTable dt2 = controllerObj3.Selectavailabletrainers();
            comboBox4.DataSource = dt2;
            comboBox4.DisplayMember = "Fname";
            comboBox4.ValueMember = "Trainer_ID";

            email = mail;
            pass = p;
        }

        private void Player_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex == 0)
            {
                comboBox1.DataSource=controllerObj.SelectCourt(0);
            }
            if (comboBox2.SelectedIndex == 1)
            {
                comboBox1.DataSource = controllerObj.SelectCourt(1);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(controllerObj2!=null)
            comboBox3.DataSource = controllerObj2.SelectCourtname(comboBox1.SelectedValue.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int r = controllerObj.BookCourt(email, pass , comboBox3.SelectedValue.ToString(), dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
            if (r == 1)
            {
                MessageBox.Show("Court is Booked Successfully");
            }
            else if (r != 1)
            {
                MessageBox.Show("failed ! Court is not Booked");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = controllerObj.BookTrainingsession(email,pass,comboBox3.SelectedValue.ToString(), dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), comboBox4.SelectedValue.ToString());
            if (r == 1)
            {
                MessageBox.Show("Training session is Booked Successfully");
            }
            else if (r != 1)
            {
                MessageBox.Show("failed ! Training session is not Booked");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int r = controllerObj.DeleteCourtBookings(email,pass);
            if (r == 1)
            {
                MessageBox.Show("Court booking is deleted Successfully");
            }
            else if (r != 1)
            {
                MessageBox.Show("failed ! Booking is not deleted ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int r = controllerObj.DeleteTrainingsession(email, pass,comboBox4.SelectedValue.ToString());
            if (r == 1)
            {
                MessageBox.Show("Session booking is deleted Successfully");
            }
            else if (r != 1)
            {
                MessageBox.Show("failed ! Booking is not deleted ");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Trainer_Myaccount1 R = new Trainer_Myaccount1(pass, email);
            R.Show();
        }
    }
}
