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
    public partial class Update_Tournament : Form
    {
        Controller controllerObj;
        string tourId;
        public Update_Tournament(string ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            tourId = ID;
            textBox2.Text = Convert.ToString(controllerObj.SelectTournamentData(tourId).Rows[0][0]);
            dateTimePicker2.Value = DateTime.Parse(Convert.ToString(controllerObj.SelectTournamentData(tourId).Rows[0][1]));



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dateTimePicker2.Value== DateTime.Parse(Convert.ToString(controllerObj.SelectTournamentData(tourId).Rows[0][1]))
                && textBox2.Text == Convert.ToString(controllerObj.SelectTournamentData(tourId).Rows[0][0]))
            {
                MessageBox.Show("Nothing Changed! Please Update the tounament data");
                return;
            }
           if (dateTimePicker2.Value<DateTime.Now)
            {
                MessageBox.Show("Can't Update Date to a Past one, Please Choose an upcoming date");
                return;
            }

            int test =controllerObj.UpdateTournament(tourId, dateTimePicker2.Value, textBox2.Text);
            if (test<=0)
            {
                MessageBox.Show("Couldn't Update");
                return;
            }

            MessageBox.Show("Tournament Updated");


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
