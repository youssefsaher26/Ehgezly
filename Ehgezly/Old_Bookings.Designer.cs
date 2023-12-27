namespace Ehgezly
{
    partial class Old_Bookings
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
            this.bookingsgridview = new System.Windows.Forms.DataGridView();
            this.writerev = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingsgridview
            // 
            this.bookingsgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingsgridview.Location = new System.Drawing.Point(0, 1);
            this.bookingsgridview.Name = "bookingsgridview";
            this.bookingsgridview.RowHeadersWidth = 51;
            this.bookingsgridview.RowTemplate.Height = 24;
            this.bookingsgridview.Size = new System.Drawing.Size(800, 398);
            this.bookingsgridview.TabIndex = 0;
            this.bookingsgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingsgridview_CellContentClick);
            // 
            // writerev
            // 
            this.writerev.Location = new System.Drawing.Point(455, 463);
            this.writerev.Name = "writerev";
            this.writerev.Size = new System.Drawing.Size(273, 50);
            this.writerev.TabIndex = 1;
            this.writerev.Text = "Review Court";
            this.writerev.UseVisualStyleBackColor = true;
            this.writerev.Click += new System.EventHandler(this.writerev_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Review Trainer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Old_Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.writerev);
            this.Controls.Add(this.bookingsgridview);
            this.Name = "Old_Bookings";
            this.Text = "Old Bookings";
            this.Load += new System.EventHandler(this.Old_Bookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsgridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookingsgridview;
        private System.Windows.Forms.Button writerev;
        private System.Windows.Forms.Button button1;
    }
}