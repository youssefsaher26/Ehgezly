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
    public partial class Manager_Homepage : Form
    {
        Controller controllerObj;
        string managerId;
        public Manager_Homepage(string email)
        {
            InitializeComponent();
            controllerObj = new Controller();
            managerId=controllerObj.GetID(email);
        }

        private void Manager_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void oldmnrequests_Click(object sender, EventArgs e)
        {
            Old_Bookings old_Bookings = new Old_Bookings(managerId, "maintenance");
            old_Bookings.Show();
        }
    }
}
