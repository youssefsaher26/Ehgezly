namespace Ehgezly
{
    partial class Admin_Homepage
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
            this.TrainerComplaints = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrainerComplaints
            // 
            this.TrainerComplaints.Location = new System.Drawing.Point(86, 77);
            this.TrainerComplaints.Name = "TrainerComplaints";
            this.TrainerComplaints.Size = new System.Drawing.Size(180, 35);
            this.TrainerComplaints.TabIndex = 0;
            this.TrainerComplaints.Text = "Trainer Complaints";
            this.TrainerComplaints.UseVisualStyleBackColor = true;
            this.TrainerComplaints.Click += new System.EventHandler(this.TrainerComplaints_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Admin_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TrainerComplaints);
            this.Name = "Admin_Homepage";
            this.Text = "Admin_Homepage";
            this.Load += new System.EventHandler(this.Admin_Homepage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TrainerComplaints;
        private System.Windows.Forms.Button button2;
    }
}