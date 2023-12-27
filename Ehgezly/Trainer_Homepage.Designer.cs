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
            this.oldtrainingsessions = new System.Windows.Forms.Button();
            this.Add_Avilable_Timeslots = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.End_Date_Time = new System.Windows.Forms.Label();
            this.Start_Date_Time = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Trainer_Name = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // Profile
            // 
            this.Profile.Image = global::Ehgezly.Properties.Resources.my_account;
            this.Profile.Location = new System.Drawing.Point(681, 14);
            this.Profile.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(156, 92);
            this.Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile.TabIndex = 0;
            this.Profile.TabStop = false;
            this.Profile.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // My_Account
            // 
            this.My_Account.AutoSize = true;
            this.My_Account.Location = new System.Drawing.Point(725, 114);
            this.My_Account.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.My_Account.Name = "My_Account";
            this.My_Account.Size = new System.Drawing.Size(76, 16);
            this.My_Account.TabIndex = 1;
            this.My_Account.Text = "My Account";
            this.My_Account.Click += new System.EventHandler(this.label1_Click);
            // 
            // oldtrainingsessions
            // 
            this.oldtrainingsessions.Location = new System.Drawing.Point(345, 96);
            this.oldtrainingsessions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oldtrainingsessions.Name = "oldtrainingsessions";
            this.oldtrainingsessions.Size = new System.Drawing.Size(216, 31);
            this.oldtrainingsessions.TabIndex = 2;
            this.oldtrainingsessions.Text = "Old Training Sessions";
            this.oldtrainingsessions.UseVisualStyleBackColor = true;
            this.oldtrainingsessions.Click += new System.EventHandler(this.oldtrainingsessions_Click);
            // 
            // Add_Avilable_Timeslots
            // 
            this.Add_Avilable_Timeslots.Location = new System.Drawing.Point(216, 427);
            this.Add_Avilable_Timeslots.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_Avilable_Timeslots.Name = "Add_Avilable_Timeslots";
            this.Add_Avilable_Timeslots.Size = new System.Drawing.Size(364, 38);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 327);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(364, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(215, 379);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(364, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // End_Date_Time
            // 
            this.End_Date_Time.AutoSize = true;
            this.End_Date_Time.Location = new System.Drawing.Point(36, 382);
            this.End_Date_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.End_Date_Time.Name = "End_Date_Time";
            this.End_Date_Time.Size = new System.Drawing.Size(123, 16);
            this.End_Date_Time.TabIndex = 6;
            this.End_Date_Time.Text = "End Date and Time";
            this.End_Date_Time.Click += new System.EventHandler(this.label2_Click);
            // 
            // Start_Date_Time
            // 
            this.Start_Date_Time.AutoSize = true;
            this.Start_Date_Time.Location = new System.Drawing.Point(33, 327);
            this.Start_Date_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Start_Date_Time.Name = "Start_Date_Time";
            this.Start_Date_Time.Size = new System.Drawing.Size(126, 16);
            this.Start_Date_Time.TabIndex = 7;
            this.Start_Date_Time.Text = "Start Date and Time";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 271);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(364, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Trainer_Name
            // 
            this.Trainer_Name.AutoSize = true;
            this.Trainer_Name.Location = new System.Drawing.Point(40, 281);
            this.Trainer_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Trainer_Name.Name = "Trainer_Name";
            this.Trainer_Name.Size = new System.Drawing.Size(90, 16);
            this.Trainer_Name.TabIndex = 9;
            this.Trainer_Name.Text = "Trainer Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 166);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel Upcoming Tournamets";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(333, 166);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "Check  Upcoming sessions";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel Upcoming Sessions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Trainer_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Trainer_Name);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Start_Date_Time);
            this.Controls.Add(this.End_Date_Time);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Add_Avilable_Timeslots);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.oldtrainingsessions);
            this.Controls.Add(this.My_Account);
            this.Controls.Add(this.Profile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}