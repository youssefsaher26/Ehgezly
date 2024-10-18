using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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
                string pattern2 = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                if (!Regex.IsMatch(Email.Text, pattern2))
                {
                    MessageBox.Show("Please enter a valid email");
                    return;
                }

                string pattern3 = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()-_+=])[A-Za-z\d!@#$%^&*()-_+=]{8,}$";

               if(!Regex.IsMatch(Password.Text, pattern3))
                {
                    MessageBox.Show("Please Choose a valid Password that has at least 8 characters, including at least one uppercase letter, one lowercase letter, one digit, and one special character ");
                    return;

                }

                if (comboBox1.SelectedIndex == 0)
                {
                    string pattern = @"^01\d{9}$";

                    // Use Regex.IsMatch to check if the phone number matches the pattern


                    if (!Regex.IsMatch(PhoneNumber.Text, pattern))
                    {
                        label10.Show();
                    }
                    else
                    {
                      

                        int r = controllerObj.InsertPlayer(Fname.Text, Lname.Text, M.Text[0], dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), Email.Text, Password.Text, PhoneNumber.Text);
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

                    string pattern = @"^01\d{9}$";

                    // Use Regex.IsMatch to check if the phone number matches the pattern
                  
 
                    if (!Regex.IsMatch(PhoneNumber.Text, pattern))
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
                    string pattern = @"^01\d{9}$";

                    // Use Regex.IsMatch to check if the phone number matches the pattern


                    if (!Regex.IsMatch(PhoneNumber.Text, pattern))
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
                    string pattern = @"^01\d{9}$";

                    // Use Regex.IsMatch to check if the phone number matches the pattern


                    if (!Regex.IsMatch(PhoneNumber.Text, pattern))
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

                string pattern3 = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()-_+=])[A-Za-z\d!@#$%^&*()-_+=]{8,}$";

                if (!Regex.IsMatch(Password.Text, pattern3)) 
                {
                    MessageBox.Show("Please Choose a valid Password that has at least 8 characters, including at least one uppercase letter, one lowercase letter, one digit, and one special character ");
                    return;

                }
                string pattern2 = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                if (!Regex.IsMatch(Email.Text, pattern2)) 
                {
                    MessageBox.Show("Please enter a valid email");
                    return;
                }

                if (comboBox1.SelectedIndex == 0)
                {
                    string pattern = @"^01\d{9}$";

                    // Use Regex.IsMatch to check if the phone number matches the pattern


                    if (!Regex.IsMatch(PhoneNumber.Text, pattern))
                    {
                        label10.Show();
                    }
                    else
                    {
                        int r = controllerObj.InsertPlayer(Fname.Text, Lname.Text, F.Text[0], dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), Email.Text, Password.Text, PhoneNumber.Text);
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
                    string pattern = @"^01\d{9}$";

                    // Use Regex.IsMatch to check if the phone number matches the pattern


                    if (!Regex.IsMatch(PhoneNumber.Text, pattern))
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
                    string pattern = @"^01\d{9}$";

                    // Use Regex.IsMatch to check if the phone number matches the pattern


                    if (!Regex.IsMatch(PhoneNumber.Text, pattern))
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
                    string pattern = @"^01\d{9}$";

                    // Use Regex.IsMatch to check if the phone number matches the pattern


                    if (!Regex.IsMatch(PhoneNumber.Text, pattern))
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