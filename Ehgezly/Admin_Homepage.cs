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
    public partial class Admin_Homepage : Form
    {
        Controller controllerObj;
        string AdminID;
        string email;
        string pass;

        public Admin_Homepage(string p, string mail, string ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            AdminID = ID;
            email = mail;
            pass = p;
        }

        private void Admin_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void TrainerComplaints_Click(object sender, EventArgs e)
        {
            Trainer_Complaints trainerComplaints = new Trainer_Complaints(AdminID);
            trainerComplaints.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin_MyAcc R = new Admin_MyAcc(pass, email);
            R.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
