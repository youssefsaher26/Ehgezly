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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Ehgezly
{
    public partial class Create_Trainer : Form
    {
        Controller controllerObj;
        public Create_Trainer()
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
                    if (radioButton2.Checked)
                    {
                        int r = controllerObj.RegisterTrainer(Fname.Text, Lname.Text, M.Text[0], dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), Email.Text, Password.Text, PhoneNumber.Text, radioButton2.Text);
                        if (r == 1)
                        {
                            MessageBox.Show("Trainer Registered Successfly");
                        }
                        else if (r != 1)
                        {
                            MessageBox.Show("Trainer Registered Failed");
                        }
                    }
                    if (radioButton1.Checked)
                    {
                        int r = controllerObj.RegisterTrainer(Fname.Text, Lname.Text, M.Text[0], dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), Email.Text, Password.Text, PhoneNumber.Text, radioButton1.Text);
                        if (r == 1)
                        {
                            MessageBox.Show("Trainer Registered Successfly");
                        }
                        else if (r != 1)
                        {
                            MessageBox.Show("Trainer Registered Failed");
                        }
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
                    if (radioButton2.Checked)
                    {
                        int r = controllerObj.RegisterTrainer(Fname.Text, Lname.Text, M.Text[0], dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), Email.Text, Password.Text, PhoneNumber.Text, radioButton2.Text);
                        if (r == 1)
                        {
                            MessageBox.Show("Account Registered Successfly");
                        }
                        else if (r != 1)
                        {
                            MessageBox.Show("Account Registered Failed");
                        }
                    }
                    if (radioButton1.Checked)
                    {
                        int r = controllerObj.RegisterTrainer(Fname.Text, Lname.Text, M.Text[0], dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), Email.Text, Password.Text, PhoneNumber.Text, radioButton1.Text);
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

        private void M_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void F_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
