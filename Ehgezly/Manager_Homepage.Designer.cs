namespace Ehgezly
{
    partial class Manager_Homepage
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
            this.My_Account = new System.Windows.Forms.Label();
            this.Update_Account = new System.Windows.Forms.PictureBox();
            this.oldmnrequests = new System.Windows.Forms.Button();
            this.Court_name = new System.Windows.Forms.Label();
            this.Court_name_comboBox1 = new System.Windows.Forms.ComboBox();
            this.Start_Date_Time = new System.Windows.Forms.Label();
            this.End_Date_Time = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Add_Avilable_Timeslots = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Update_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // My_Account
            // 
            this.My_Account.AutoSize = true;
            this.My_Account.Location = new System.Drawing.Point(680, 103);
            this.My_Account.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.My_Account.Name = "My_Account";
            this.My_Account.Size = new System.Drawing.Size(76, 16);
            this.My_Account.TabIndex = 15;
            this.My_Account.Text = "My Account";
            this.My_Account.Click += new System.EventHandler(this.label6_Click);
            // 
            // Update_Account
            // 
            this.Update_Account.Image = global::Ehgezly.Properties.Resources.my_account;
            this.Update_Account.Location = new System.Drawing.Point(660, 22);
            this.Update_Account.Margin = new System.Windows.Forms.Padding(4);
            this.Update_Account.Name = "Update_Account";
            this.Update_Account.Size = new System.Drawing.Size(117, 75);
            this.Update_Account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Update_Account.TabIndex = 14;
            this.Update_Account.TabStop = false;
            this.Update_Account.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // oldmnrequests
            // 
            this.oldmnrequests.Location = new System.Drawing.Point(523, 356);
            this.oldmnrequests.Name = "oldmnrequests";
            this.oldmnrequests.Size = new System.Drawing.Size(233, 29);
            this.oldmnrequests.TabIndex = 0;
            this.oldmnrequests.Text = "Old maintenance requests";
            this.oldmnrequests.UseVisualStyleBackColor = true;
            this.oldmnrequests.Click += new System.EventHandler(this.oldmnrequests_Click);
            // 
            // Court_name
            // 
            this.Court_name.AutoSize = true;
            this.Court_name.Location = new System.Drawing.Point(38, 223);
            this.Court_name.Name = "Court_name";
            this.Court_name.Size = new System.Drawing.Size(78, 16);
            this.Court_name.TabIndex = 22;
            this.Court_name.Text = "Court Name";
            // 
            // Court_name_comboBox1
            // 
            this.Court_name_comboBox1.FormattingEnabled = true;
            this.Court_name_comboBox1.Location = new System.Drawing.Point(169, 215);
            this.Court_name_comboBox1.Name = "Court_name_comboBox1";
            this.Court_name_comboBox1.Size = new System.Drawing.Size(274, 24);
            this.Court_name_comboBox1.TabIndex = 21;
            this.Court_name_comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Start_Date_Time
            // 
            this.Start_Date_Time.AutoSize = true;
            this.Start_Date_Time.Location = new System.Drawing.Point(33, 273);
            this.Start_Date_Time.Name = "Start_Date_Time";
            this.Start_Date_Time.Size = new System.Drawing.Size(126, 16);
            this.Start_Date_Time.TabIndex = 20;
            this.Start_Date_Time.Text = "Start Date and Time";
            // 
            // End_Date_Time
            // 
            this.End_Date_Time.AutoSize = true;
            this.End_Date_Time.Location = new System.Drawing.Point(35, 317);
            this.End_Date_Time.Name = "End_Date_Time";
            this.End_Date_Time.Size = new System.Drawing.Size(123, 16);
            this.End_Date_Time.TabIndex = 19;
            this.End_Date_Time.Text = "End Date and Time";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(169, 315);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(274, 22);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 273);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // Add_Avilable_Timeslots
            // 
            this.Add_Avilable_Timeslots.Location = new System.Drawing.Point(170, 354);
            this.Add_Avilable_Timeslots.Name = "Add_Avilable_Timeslots";
            this.Add_Avilable_Timeslots.Size = new System.Drawing.Size(273, 31);
            this.Add_Avilable_Timeslots.TabIndex = 16;
            this.Add_Avilable_Timeslots.Text = "Add Avilable Timeslots";
            this.Add_Avilable_Timeslots.UseVisualStyleBackColor = true;
            this.Add_Avilable_Timeslots.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manager_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Court_name);
            this.Controls.Add(this.Court_name_comboBox1);
            this.Controls.Add(this.Start_Date_Time);
            this.Controls.Add(this.End_Date_Time);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Add_Avilable_Timeslots);
            this.Controls.Add(this.My_Account);
            this.Controls.Add(this.Update_Account);
            this.Controls.Add(this.oldmnrequests);
            this.Name = "Manager_Homepage";
            this.Text = "Manager_Homepage";
            this.Load += new System.EventHandler(this.Manager_Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Update_Account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label My_Account;
        private System.Windows.Forms.PictureBox Update_Account;

        private System.Windows.Forms.Button oldmnrequests;
        private System.Windows.Forms.Label Court_name;
        private System.Windows.Forms.ComboBox Court_name_comboBox1;
        private System.Windows.Forms.Label Start_Date_Time;
        private System.Windows.Forms.Label End_Date_Time;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Add_Avilable_Timeslots;
    }
}