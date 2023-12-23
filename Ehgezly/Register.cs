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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Ehgezly
{
    public partial class Register : Form
    {
        Controller controllerObj;
        public Register()
        {
            InitializeComponent();
            groupBox1.Hide();
            controllerObj = new Controller();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            label10.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                groupBox1.Show();
            }
            if (comboBox1.SelectedIndex != 1)
            {
                groupBox1.Hide();
            }
            Fname.Clear();
            Email.Clear();
            Password.Clear();
            Lname.Clear();
            M.Checked=false;
            F.Checked=false;
            PhoneNumber.Clear();
            radioButton3.Checked = false;
            radioButton4.Checked = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Fname.Text == "" || Lname.Text == "" || Email.Text == ""|| Password.Text == "" || PhoneNumber.Text == "")
            {
                MessageBox.Show("Please, insert all values");
                return;
            }
            if (M.Checked)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    if (PhoneNumber.TextLength != 11)
                    {
                        label10.Show();
                    }
                    else
                    {
                        int r = controllerObj.RegisterPlayer(Fname.Text, Lname.Text, M.Text[0], dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), Email.Text, Password.Text, PhoneNumber.Text);
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
                if (comboBox1.SelectedIndex == 1)
                {
                    if (PhoneNumber.TextLength != 11)
                    {
                        label10.Show();
                    }
                    else
                    {
                        if (radioButton3.Checked)
                        {
                            int r = controllerObj.RegisterTrainer(Fname.Text, Lname.Text, M.Text[0], dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), Email.Text, Password.Text, PhoneNumber.Text, radioButton3.Text);
                            if (r == 1)
                            {
                                MessageBox.Show("Account Registered Successfly");
                            }
                            else if (r != 1)
                            {
                                MessageBox.Show("Account Registered Failed");
                            }
                        }
                        if (radioButton4.Checked)
                        {
                            int r = controllerObj.RegisterTrainer(Fname.Text, Lname.Text, M.Text[0], dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), Email.Text, Password.Text, PhoneNumber.Text, radioButton4.Text);
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
                if (comboBox1.SelectedIndex == 2)
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
                if (comboBox1.SelectedIndex == 3)
                {
                    if (PhoneNumber.TextLength != 11)
                    {
                        label10.Show();
                    }
                    else
                    {
                        int r = controllerObj.RegisterAdmin(Fname.Text, Lname.Text, M.Text[0], dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), Email.Text, Password.Text, PhoneNumber.Text);
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
            else if (F.Checked)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    if (PhoneNumber.TextLength != 11)
                    {
                        label10.Show();
                    }
                    else
                    {
                        int r = controllerObj.RegisterPlayer(Fname.Text, Lname.Text, F.Text[0], dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), Email.Text, Password.Text, PhoneNumber.Text);
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
                if (comboBox1.SelectedIndex == 1)
                {
                    if (PhoneNumber.TextLength != 11)
                    {
                        label10.Show();
                    }
                    else
                    {
                        if (radioButton3.Checked)
                        {
                            int r = controllerObj.RegisterTrainer(Fname.Text, Lname.Text, F.Text[0], dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), Email.Text, Password.Text, PhoneNumber.Text, radioButton3.Text);
                            if (r == 1)
                            {
                                MessageBox.Show("Account Registered Successfly");
                            }
                            else if (r != 1)
                            {
                                MessageBox.Show("Account Registered Failed");
                            }
                        }
                        if (radioButton4.Checked)
                        {
                            int r = controllerObj.RegisterTrainer(Fname.Text, Lname.Text, F.Text[0], dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), Email.Text, Password.Text, PhoneNumber.Text, radioButton4.Text);
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
                if (comboBox1.SelectedIndex == 2)
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
                if (comboBox1.SelectedIndex == 3)
                {
                    if (PhoneNumber.TextLength != 11)
                    {
                        label10.Show();
                    }
                    else
                    {
                        int r = controllerObj.RegisterAdmin(Fname.Text, Lname.Text, M.Text[0], dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), Email.Text, Password.Text, PhoneNumber.Text);
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

        private void PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}