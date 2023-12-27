namespace Ehgezly
{
    partial class Show_Complaints
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Openselected = new System.Windows.Forms.Button();
            this.TrainerComplaintgridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TrainerComplaintgridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Openselected
            // 
            this.Openselected.Location = new System.Drawing.Point(603, 370);
            this.Openselected.Name = "Openselected";
            this.Openselected.Size = new System.Drawing.Size(73, 35);
            this.Openselected.TabIndex = 1;
            this.Openselected.Text = "Open ";
            this.Openselected.UseVisualStyleBackColor = true;
            this.Openselected.Click += new System.EventHandler(this.Openselected_Click);
            // 
            // TrainerComplaintgridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.TrainerComplaintgridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TrainerComplaintgridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainerComplaintgridView.Location = new System.Drawing.Point(-1, 0);
            this.TrainerComplaintgridView.Name = "TrainerComplaintgridView";
            this.TrainerComplaintgridView.RowHeadersWidth = 51;
            this.TrainerComplaintgridView.RowTemplate.Height = 24;
            this.TrainerComplaintgridView.Size = new System.Drawing.Size(478, 450);
            this.TrainerComplaintgridView.TabIndex = 0;
            this.TrainerComplaintgridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrainerComplaintgridView_CellContentClick);
            // 
            // Trainer_Complaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Openselected);
            this.Controls.Add(this.TrainerComplaintgridView);
            this.Name = "Trainer_Complaints";
            this.Text = "Trainer Complaints";
            this.Load += new System.EventHandler(this.Trainer_Complaints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrainerComplaintgridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Openselected;
        private System.Windows.Forms.DataGridView TrainerComplaintgridView;
    }
}