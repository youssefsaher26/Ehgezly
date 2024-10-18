namespace Ehgezly
{
    partial class AverageBookings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.averageBookingsDataSet = new Ehgezly.AverageBookingsDataSet();
            this.averageBookingsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AvgBookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Ehgezly.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.averageBookingsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageBookingsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvgBookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ehgezly.AvgBookingReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // averageBookingsDataSet
            // 
            this.averageBookingsDataSet.DataSetName = "AverageBookingsDataSet";
            this.averageBookingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // averageBookingsDataSetBindingSource
            // 
            this.averageBookingsDataSetBindingSource.DataSource = this.averageBookingsDataSet;
            this.averageBookingsDataSetBindingSource.Position = 0;
            this.averageBookingsDataSetBindingSource.CurrentChanged += new System.EventHandler(this.averageBookingsDataSetBindingSource_CurrentChanged);
            // 
            // AvgBookingsBindingSource
            // 
            this.AvgBookingsBindingSource.DataMember = "AvgBookings";
            this.AvgBookingsBindingSource.DataSource = this.averageBookingsDataSet;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // AverageBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AverageBookings";
            this.Text = "AverageBookings";
            this.Load += new System.EventHandler(this.AverageBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.averageBookingsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageBookingsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvgBookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource averageBookingsDataSetBindingSource;
        private AverageBookingsDataSet averageBookingsDataSet;
        private System.Windows.Forms.BindingSource AvgBookingsBindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
    }
}