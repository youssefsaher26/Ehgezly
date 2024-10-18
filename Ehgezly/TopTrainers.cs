using DBapplication;
using Microsoft.Reporting.WinForms;
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
    public partial class TopTrainers : Form
    {
        Controller controllerObj;
        public TopTrainers()
        {
            InitializeComponent();
            controllerObj = new Controller();

        }
        private void TopTrainers_Load(object sender, EventArgs e)
        {
            var dataSource = new ReportDataSource("TopTrainersDataSet", controllerObj.GetTopRatedTrainers());
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
