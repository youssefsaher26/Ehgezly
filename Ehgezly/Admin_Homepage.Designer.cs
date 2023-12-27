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
            this.label6 = new System.Windows.Forms.Label();
            this.Create_Manager_Account = new System.Windows.Forms.Button();
            this.Show_Manager_Accounts = new System.Windows.Forms.Button();
            this.Show_Trainer_Accounts = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Create_Trainer_Account = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TrainerComplaints
            // 
            this.TrainerComplaints.Location = new System.Drawing.Point(608, 168);
            this.TrainerComplaints.Name = "TrainerComplaints";
            this.TrainerComplaints.Size = new System.Drawing.Size(180, 35);
            this.TrainerComplaints.TabIndex = 0;
            this.TrainerComplaints.Text = "Trainer Complaints";
            this.TrainerComplaints.UseVisualStyleBackColor = true;
            this.TrainerComplaints.Click += new System.EventHandler(this.TrainerComplaints_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(669, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "My Account";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Create_Manager_Account
            // 
            this.Create_Manager_Account.Location = new System.Drawing.Point(38, 89);
            this.Create_Manager_Account.Name = "Create_Manager_Account";
            this.Create_Manager_Account.Size = new System.Drawing.Size(180, 32);
            this.Create_Manager_Account.TabIndex = 16;
            this.Create_Manager_Account.Text = "Create Manager Account";
            this.Create_Manager_Account.UseVisualStyleBackColor = true;
            this.Create_Manager_Account.Click += new System.EventHandler(this.Create_Manager_Click);
            // 
            // Show_Manager_Accounts
            // 
            this.Show_Manager_Accounts.Location = new System.Drawing.Point(38, 168);
            this.Show_Manager_Accounts.Name = "Show_Manager_Accounts";
            this.Show_Manager_Accounts.Size = new System.Drawing.Size(180, 35);
            this.Show_Manager_Accounts.TabIndex = 17;
            this.Show_Manager_Accounts.Text = "Show Manager Accounts";
            this.Show_Manager_Accounts.UseVisualStyleBackColor = true;
            this.Show_Manager_Accounts.Click += new System.EventHandler(this.Show_Managers_Click);
            // 
            // Show_Trainer_Accounts
            // 
            this.Show_Trainer_Accounts.Location = new System.Drawing.Point(256, 168);
            this.Show_Trainer_Accounts.Name = "Show_Trainer_Accounts";
            this.Show_Trainer_Accounts.Size = new System.Drawing.Size(180, 35);
            this.Show_Trainer_Accounts.TabIndex = 18;
            this.Show_Trainer_Accounts.Text = "Show Trainer Accounts";
            this.Show_Trainer_Accounts.UseVisualStyleBackColor = true;
            this.Show_Trainer_Accounts.Click += new System.EventHandler(this.Show_Trainer_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ehgezly.Properties.Resources.my_account;
            this.pictureBox1.Location = new System.Drawing.Point(649, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Create_Trainer_Account
            // 
            this.Create_Trainer_Account.Location = new System.Drawing.Point(256, 88);
            this.Create_Trainer_Account.Name = "Create_Trainer_Account";
            this.Create_Trainer_Account.Size = new System.Drawing.Size(180, 35);
            this.Create_Trainer_Account.TabIndex = 19;
            this.Create_Trainer_Account.Text = "Create Trainer Account";
            this.Create_Trainer_Account.UseVisualStyleBackColor = true;
            this.Create_Trainer_Account.Click += new System.EventHandler(this.Create_Trainer_Click);
            // 
            // Admin_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Create_Trainer_Account);
            this.Controls.Add(this.Show_Trainer_Accounts);
            this.Controls.Add(this.Show_Manager_Accounts);
            this.Controls.Add(this.Create_Manager_Account);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TrainerComplaints);
            this.Name = "Admin_Homepage";
            this.Text = "Admin_Homepage";
            this.Load += new System.EventHandler(this.Admin_Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TrainerComplaints;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Create_Manager_Account;
        private System.Windows.Forms.Button Show_Manager_Accounts;
        private System.Windows.Forms.Button Show_Trainer_Accounts;
        private System.Windows.Forms.Button Create_Trainer_Account;
    }
}