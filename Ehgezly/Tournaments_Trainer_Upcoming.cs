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
    public partial class Tournaments_Trainer_Upcoming : Form
    {
        string password;
        string email;
        Controller controllerObj;
        public Tournaments_Trainer_Upcoming(string pass, string mail)
        {
            InitializeComponent();
            password = pass;
            email = mail;
            controllerObj = new Controller();
            dataGridView1.DataSource = controllerObj.ViewUpcomingTournaments(email, password);
        }

        private void Tournaments_Trainer_Upcoming_Load(object sender, EventArgs e)
        {

        }
    }
}
