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
    public partial class Trainer_Homepage : Form
    {
        Controller controllerObj;
        string password;
        string email;
        public Trainer_Homepage(string p, string mail)
        {
             InitializeComponent();
             password=p;
             email=mail;
            controllerObj = new Controller();
        }

        private void Trainer_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Trainer_Myaccount1 R = new Trainer_Myaccount1(password, email);
            R.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Trainer_Myaccount1 R = new Trainer_Myaccount1(password, email);
            R.Show();
        }

        private void oldtrainingsessions_Click(object sender, EventArgs e)
        {
            
                Old_Bookings old_Bookings = new Old_Bookings(controllerObj.GetID(email), "Trainer");
                old_Bookings.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cancel_Sessions R = new Cancel_Sessions(password, email);
            R.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tournaments_Trainer R = new Tournaments_Trainer(password, email);
            R.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tournaments_Trainer_Upcoming R = new Tournaments_Trainer_Upcoming(password, email);
            R.Show();
        }
    }
}
