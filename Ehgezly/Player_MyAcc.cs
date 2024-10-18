using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ehgezly
{
    public partial class Player_MyAcc : Form
    {
        Controller controllerObj;
        string email;
        string password;
        public Player_MyAcc(string p, string mail)
        {
            InitializeComponent();
            controllerObj = new Controller();
            email = mail;
            password = p;
            Fnamebox.ReadOnly = true;
            Lnamebox.ReadOnly = true;
            Emailbox.ReadOnly = true;
            Passwordbox.ReadOnly = true;
            Phonenumbbox.ReadOnly = true;
            button2.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pattern2 = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(Emailbox.Text, pattern2))
            {
                MessageBox.Show("Please enter a valid email");
                return;
            }

            string pattern3 = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()-_+=])[A-Za-z\d!@#$%^&*()-_+=]{8,}$";

            if (!Regex.IsMatch(Passwordbox.Text, pattern3))
            {
                MessageBox.Show("Please Choose a valid Password that has at least 8 characters, including at least one uppercase letter, one lowercase letter, one digit, and one special character ");
                return;

            }
            string pattern = @"^01\d{9}$";

            // Use Regex.IsMatch to check if the phone number matches the pattern


            if (!Regex.IsMatch(Phonenumbbox.Text, pattern))
            {
                MessageBox.Show("Please enter a valid Phone Number that has 11 digits and starts with 01 ");
                return;
            }
            int r = Convert.ToInt32(controllerObj.UpdateAccInfo(Fnamebox.Text, Lnamebox.Text, Emailbox.Text, Passwordbox.Text, Phonenumbbox.Text, email));
            if (r == 1)
            {
                MessageBox.Show("Update Successful");
                Application.Restart();
                Environment.Exit(0);

            }
            else if (r == 0)
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void Player_MyAcc_Load(object sender, EventArgs e)
        {
            DataTable dt;
            dt = controllerObj.ViewAccountPlayer(email, password);
            Fnamebox.Text = dt.Rows[0][0].ToString();
            Lnamebox.Text = dt.Rows[0][1].ToString();
            Emailbox.Text = dt.Rows[0][2].ToString();
            Passwordbox.Text = dt.Rows[0][3].ToString();
            Phonenumbbox.Text = dt.Rows[0][4].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fnamebox.BackColor = Color.White;
            Lnamebox.BackColor = Color.White;
            Emailbox.BackColor = Color.White;
            Passwordbox.BackColor = Color.White;
            Phonenumbbox.BackColor = Color.White;
            Fnamebox.ReadOnly = false;
            Lnamebox.ReadOnly = false;
            Emailbox.ReadOnly = false;
            Passwordbox.ReadOnly = false;
            Phonenumbbox.ReadOnly = false;
            button2.Show();
        }
    }
}
