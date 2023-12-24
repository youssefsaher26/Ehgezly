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

        }
    }
}
