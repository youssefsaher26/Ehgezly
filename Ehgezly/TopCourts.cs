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
    public partial class TopCourts : Form
    {
        Controller controllerObj;
        public TopCourts()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void TopCourts_Load(object sender, EventArgs e)
        {

            var dataSource = new ReportDataSource("TopCourtDataSet", controllerObj.GetTopRatedCourts());
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
