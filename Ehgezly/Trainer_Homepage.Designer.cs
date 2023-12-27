namespace Ehgezly
{
    partial class Trainer_Homepage
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
            this.Profile = new System.Windows.Forms.PictureBox();
            this.My_Account = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oldtrainingsessions = new System.Windows.Forms.Button();
            this.Add_Avilable_Timeslots = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.End_Date_Time = new System.Windows.Forms.Label();
            this.Start_Date_Time = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Trainer_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Profile
            // 
            this.Profile.Image = global::Ehgezly.Properties.Resources.my_account;
            this.Profile.Location = new System.Drawing.Point(667, 15);
            this.Profile.Margin = new System.Windows.Forms.Padding(4);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(117, 75);
            this.Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile.TabIndex = 0;
            this.Profile.TabStop = false;
            this.Profile.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // My_Account
            // label1
            // 
            this.My_Account.AutoSize = true;
            this.My_Account.Location = new System.Drawing.Point(687, 96);
            this.My_Account.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.My_Account.Name = "My_Account";
            this.My_Account.Size = new System.Drawing.Size(76, 16);
            this.My_Account.TabIndex = 1;
            this.My_Account.Text = "My Account";
            this.My_Account.Click += new System.EventHandler(this.label1_Click);
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // oldtrainingsessions
            // 
            this.oldtrainingsessions.Location = new System.Drawing.Point(410, 280);
            this.oldtrainingsessions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oldtrainingsessions.Name = "oldtrainingsessions";
            this.oldtrainingsessions.Size = new System.Drawing.Size(162, 25);
            this.oldtrainingsessions.TabIndex = 2;
            this.oldtrainingsessions.Text = "Old Training Sessions";
            this.oldtrainingsessions.UseVisualStyleBackColor = true;
            this.oldtrainingsessions.Click += new System.EventHandler(this.oldtrainingsessions_Click);
            // 
            // Add_Avilable_Timeslots
            // 
            this.Add_Avilable_Timeslots.Location = new System.Drawing.Point(162, 347);
            this.Add_Avilable_Timeslots.Name = "Add_Avilable_Timeslots";
            this.Add_Avilable_Timeslots.Size = new System.Drawing.Size(273, 31);
            this.Add_Avilable_Timeslots.TabIndex = 3;
            this.Add_Avilable_Timeslots.Text = "Add Avilable Timeslots";
            this.Add_Avilable_Timeslots.UseVisualStyleBackColor = true;
            this.Add_Avilable_Timeslots.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 266);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(161, 308);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(274, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // End_Date_Time
            // 
            this.End_Date_Time.AutoSize = true;
            this.End_Date_Time.Location = new System.Drawing.Point(27, 310);
            this.End_Date_Time.Name = "End_Date_Time";
            this.End_Date_Time.Size = new System.Drawing.Size(123, 16);
            this.End_Date_Time.TabIndex = 6;
            this.End_Date_Time.Text = "End Date and Time";
            this.End_Date_Time.Click += new System.EventHandler(this.label2_Click);
            // 
            // Start_Date_Time
            // 
            this.Start_Date_Time.AutoSize = true;
            this.Start_Date_Time.Location = new System.Drawing.Point(25, 266);
            this.Start_Date_Time.Name = "Start_Date_Time";
            this.Start_Date_Time.Size = new System.Drawing.Size(126, 16);
            this.Start_Date_Time.TabIndex = 7;
            this.Start_Date_Time.Text = "Start Date and Time";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 220);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Trainer_Name
            // 
            this.Trainer_Name.AutoSize = true;
            this.Trainer_Name.Location = new System.Drawing.Point(30, 228);
            this.Trainer_Name.Name = "Trainer_Name";
            this.Trainer_Name.Size = new System.Drawing.Size(90, 16);
            this.Trainer_Name.TabIndex = 9;
            this.Trainer_Name.Text = "Trainer Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel Upcoming sessions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel Upcoming Tournamets";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ehgezly.Properties.Resources.my_account;
            this.pictureBox1.Location = new System.Drawing.Point(500, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Check Upcoming Tournaments";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Trainer_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Trainer_Name);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Start_Date_Time);
            this.Controls.Add(this.End_Date_Time);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Add_Avilable_Timeslots);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oldtrainingsessions);
            this.Controls.Add(this.My_Account);
            this.Controls.Add(this.Profile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Trainer_Homepage";
            this.Text = "Trainer_Homepage";
            this.Load += new System.EventHandler(this.Trainer_Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Profile;
        private System.Windows.Forms.Label My_Account;
        private System.Windows.Forms.Button oldtrainingsessions;
        private System.Windows.Forms.Button Add_Avilable_Timeslots;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label End_Date_Time;
        private System.Windows.Forms.Label Start_Date_Time;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Trainer_Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}