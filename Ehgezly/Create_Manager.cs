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
    public partial class Create_Manager : Form
    {
        Controller controllerObj;
        public Create_Manager()
        {
            InitializeComponent();
            controllerObj = new Controller();
            label10.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (Fname.Text == "" || Lname.Text == "" || Email.Text == "" || Password.Text == "" || PhoneNumber.Text == "")
            {
                MessageBox.Show("Please, insert all values");
                return;
            }
            if (M.Checked)
            {
                if (PhoneNumber.TextLength != 11)
                {
                    label10.Show();
                }
                else
                {
                    int r = controllerObj.RegisterManager(Fname.Text, Lname.Text, M.Text[0], dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), Email.Text, Password.Text, PhoneNumber.Text);
                    if (r == 1)
                    {
                        MessageBox.Show("Account Registered Successfly");
                    }
                    else if (r != 1)
                    {
                        MessageBox.Show("Account Registered Failed");
                    }
                }
            }
            else if (F.Checked)
            {

                if (PhoneNumber.TextLength != 11)
                {
                    label10.Show();
                }
                else
                {
                    int r = controllerObj.RegisterManager(Fname.Text, Lname.Text, F.Text[0], dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), Email.Text, Password.Text, PhoneNumber.Text);
                    if (r == 1)
                    {
                        MessageBox.Show("Account Registered Successfly");
                    }
                    else if (r != 1)
                    {
                        MessageBox.Show("Account Registered Failed");
                    }
                }
            }
        }
    }
}
