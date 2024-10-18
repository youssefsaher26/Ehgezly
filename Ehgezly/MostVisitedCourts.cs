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
    public partial class MostVisitedCourts : Form
    {
        Controller controllerObj;
        public MostVisitedCourts()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void MostVisitedCourts_Load(object sender, EventArgs e)
        {
            var dataSource = new ReportDataSource("MostVisitedDataSet", controllerObj.GetPlayerVisitsCount());
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();

        }
    }
}
