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
    public partial class Show_Tournament : Form
    {
        Controller controllerObj;
        public Show_Tournament()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Show_Tournament_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewUpcomingTournaments();
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
