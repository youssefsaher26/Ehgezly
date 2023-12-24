namespace Ehgezly
{
    partial class T_Complaint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TrainerComplaintgridView = new System.Windows.Forms.DataGridView();
            this.MarkRev = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrainerComplaintgridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TrainerComplaintgridView
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.TrainerComplaintgridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TrainerComplaintgridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainerComplaintgridView.Location = new System.Drawing.Point(1, 0);
            this.TrainerComplaintgridView.Name = "TrainerComplaintgridView";
            this.TrainerComplaintgridView.RowHeadersWidth = 51;
            this.TrainerComplaintgridView.RowTemplate.Height = 24;
            this.TrainerComplaintgridView.Size = new System.Drawing.Size(1030, 450);
            this.TrainerComplaintgridView.TabIndex = 1;
            this.TrainerComplaintgridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrainerComplaintgridView_CellContentClick);
            // 
            // MarkRev
            // 
            this.MarkRev.Location = new System.Drawing.Point(708, 559);
            this.MarkRev.Name = "MarkRev";
            this.MarkRev.Size = new System.Drawing.Size(216, 53);
            this.MarkRev.TabIndex = 2;
            this.MarkRev.Text = "Mark complaint As Reviewed ";
            this.MarkRev.UseVisualStyleBackColor = true;
            this.MarkRev.Click += new System.EventHandler(this.MarkRev_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(144, 471);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(268, 212);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Action Taken ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // T_Complaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 707);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.MarkRev);
            this.Controls.Add(this.TrainerComplaintgridView);
            this.Name = "T_Complaint";
            this.Text = "T_Complaint";
            this.Load += new System.EventHandler(this.T_Complaint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrainerComplaintgridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TrainerComplaintgridView;
        private System.Windows.Forms.Button MarkRev;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}