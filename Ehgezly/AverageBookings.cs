using DBapplication;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Ehgezly
{
    public partial class AverageBookings : Form
    {

        Controller controllerObj;
        public AverageBookings()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }


        private void AverageBookings_Load(object sender, EventArgs e)
        {
            var dataSource = new ReportDataSource("AverageBookingsDataSet", controllerObj.GetAverageBookingsData()); 
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
            
        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void averageBookingsDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
