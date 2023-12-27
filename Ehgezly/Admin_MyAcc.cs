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
    public partial class Admin_MyAcc : Form
    {
        Controller controllerObj;
        string email;
        string password;
        public Admin_MyAcc(string p, string mail)
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

        private void Admin_MyAcc_Load(object sender, EventArgs e)
        {
            DataTable dt;
            dt = controllerObj.ViewAccountPlayer(email, password);
            Fnamebox.Text = dt.Rows[0][0].ToString();
            Lnamebox.Text = dt.Rows[0][1].ToString();
            Emailbox.Text = dt.Rows[0][2].ToString();
            Passwordbox.Text = dt.Rows[0][3].ToString();
            Phonenumbbox.Text = dt.Rows[0][4].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
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
