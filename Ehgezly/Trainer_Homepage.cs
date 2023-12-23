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
    public partial class Trainer_Homepage : Form
    {
        public Trainer_Homepage()
        {
            InitializeComponent();
        }

        private void Trainer_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Trainer_Myaccount1 R = new Trainer_Myaccount1();
            R.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Trainer_Myaccount1 R = new Trainer_Myaccount1();
            R.Show();
        }
    }
}
