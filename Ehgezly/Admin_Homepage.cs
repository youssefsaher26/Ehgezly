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
    public partial class Admin_Homepage : Form
    {
        String AdminID;
        public Admin_Homepage(String ID)
        {
            InitializeComponent();
            AdminID = ID;
        }

        private void Admin_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void TrainerComplaints_Click(object sender, EventArgs e)
        {
            Trainer_Complaints trainerComplaints = new Trainer_Complaints(AdminID);
            trainerComplaints.Show();
        }
    }
}
