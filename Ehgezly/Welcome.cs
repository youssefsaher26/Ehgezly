using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Ehgezly
{
    public partial class Welcome : Form
    {
        Controller controllerObj;
        public Welcome()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please, insert all values");
                return;
            }
            string email=textBox1.Text;
            string pass =textBox2.Text;
            controllerObj = new Controller();
            DataTable dt = controllerObj.CheckAccountExist(email, pass);
            if (dt==null)
            {
                MessageBox.Show("Wrong Email or password");
            }
            else
            {
                Controller controllerObj2= new Controller();
                Controller controllerObj3 = new Controller();
                Controller controllerObj4 = new Controller();

                MessageBox.Show("Login sucessfull");
                if (controllerObj.CheckAccountAdmin(email, pass) != null)
                {
                    Admin_Homepage a = new Admin_Homepage();
                    a.Show();
                }
                else if (controllerObj2.CheckAccountTrainer(email, pass) != null)
                {
                    Trainer_Homepage t = new Trainer_Homepage();
                    t.Show();
                }
                else if (controllerObj3.CheckAccountManager(email, pass) != null)
                {
                    Manager_Homepage M = new Manager_Homepage();
                    M.Show();
                }
                else if (controllerObj4.CheckAccountPlayer(email, pass) != null) 
                {
                    Player_Homepage P = new Player_Homepage();
                    P.Show();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register R = new Register();
            R.Show();
        }

        public string GetEmailValue()
        {
            return textBox1.Text;
        }
        public string GetPasswordValue()
        {
            return textBox2.Text ;
        }
    }
};
