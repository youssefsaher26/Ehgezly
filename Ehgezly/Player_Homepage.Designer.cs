namespace Ehgezly
{
    partial class Player_Homepage
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
            this.bookcourt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.booktrainsession = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Booking_Time = new System.Windows.Forms.Label();
            this.Book_Training_Session = new System.Windows.Forms.Button();
            this.Available_comboBox4 = new System.Windows.Forms.ComboBox();
            this.Available_Trainers = new System.Windows.Forms.Label();
            this.Cancelling_Bookings = new System.Windows.Forms.Button();
            this.Cancelling_tournament_Participation = new System.Windows.Forms.Button();
            this.My_Account = new System.Windows.Forms.Label();
            this.trainingsessionold = new System.Windows.Forms.Button();
            this.courtbookingold = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Ccomplaint = new System.Windows.Forms.Button();
            this.Tcomplaint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookcourt
            // 
            this.bookcourt.Location = new System.Drawing.Point(169, 398);
            this.bookcourt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookcourt.Name = "bookcourt";
            this.bookcourt.Size = new System.Drawing.Size(250, 28);
            this.bookcourt.TabIndex = 0;
            this.bookcourt.Text = "Book Court";
            this.bookcourt.UseVisualStyleBackColor = true;
            this.bookcourt.Click += new System.EventHandler(this.button1_Click_144);
            this.Book_Court.Location = new System.Drawing.Point(225, 490);
            this.Book_Court.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Book_Court.Name = "Book_Court";
            this.Book_Court.Size = new System.Drawing.Size(333, 34);
            this.Book_Court.TabIndex = 0;
            this.Book_Court.Text = "Book Court";
            this.Book_Court.UseVisualStyleBackColor = true;
            this.Book_Court.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 118);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.Court_Loc_comboBox1.FormattingEnabled = true;
            this.Court_Loc_comboBox1.Location = new System.Drawing.Point(225, 145);
            this.Court_Loc_comboBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Court_Loc_comboBox1.Name = "Court_Loc_comboBox1";
            this.Court_Loc_comboBox1.Size = new System.Drawing.Size(332, 24);
            this.Court_Loc_comboBox1.TabIndex = 1;
            this.Court_Loc_comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Football",
            "Padel"});
            this.comboBox2.Location = new System.Drawing.Point(169, 73);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(250, 24);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.Sport_Type_Combobox.Location = new System.Drawing.Point(225, 90);
            this.Sport_Type_Combobox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Sport_Type_Combobox.Name = "Sport_Type_Combobox";
            this.Sport_Type_Combobox.Size = new System.Drawing.Size(332, 24);
            this.Sport_Type_Combobox.TabIndex = 2;
            this.Sport_Type_Combobox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sport Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.Sport_Type.AutoSize = true;
            this.Sport_Type.Location = new System.Drawing.Point(56, 95);
            this.Sport_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sport_Type.Name = "Sport_Type";
            this.Sport_Type.Size = new System.Drawing.Size(74, 16);
            this.Sport_Type.TabIndex = 3;
            this.Sport_Type.Text = "Sport Type";
            this.Sport_Type.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Court Location";
            this.Court_Loc.AutoSize = true;
            this.Court_Loc.Location = new System.Drawing.Point(53, 149);
            this.Court_Loc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Court_Loc.Name = "Court_Loc";
            this.Court_Loc.Size = new System.Drawing.Size(92, 16);
            this.Court_Loc.TabIndex = 4;
            this.Court_Loc.Text = "Court Location";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Football",
            "Padel"});
            this.comboBox3.Location = new System.Drawing.Point(169, 169);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(250, 24);
            this.comboBox3.TabIndex = 5;
            this.Court_Name_comboBox3.Location = new System.Drawing.Point(225, 208);
            this.Court_Name_comboBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Court_Name_comboBox3.Name = "Court_Name_comboBox3";
            this.Court_Name_comboBox3.Size = new System.Drawing.Size(332, 24);
            this.Court_Name_comboBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Court Name";
            this.Court_Name.AutoSize = true;
            this.Court_Name.Location = new System.Drawing.Point(59, 213);
            this.Court_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Court_Name.Name = "Court_Name";
            this.Court_Name.Size = new System.Drawing.Size(78, 16);
            this.Court_Name.TabIndex = 6;
            this.Court_Name.Text = "Court Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 219);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Location = new System.Drawing.Point(231, 270);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Booking Time";
            this.Booking_Time.AutoSize = true;
            this.Booking_Time.Location = new System.Drawing.Point(56, 276);
            this.Booking_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Booking_Time.Name = "Booking_Time";
            this.Booking_Time.Size = new System.Drawing.Size(91, 16);
            this.Booking_Time.TabIndex = 8;
            this.Booking_Time.Text = "Booking Time";
            // 
            // booktrainsession
            // 
            this.booktrainsession.Location = new System.Drawing.Point(169, 342);
            this.booktrainsession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.booktrainsession.Name = "booktrainsession";
            this.booktrainsession.Size = new System.Drawing.Size(250, 28);
            this.booktrainsession.TabIndex = 9;
            this.booktrainsession.Text = "Book Training session";
            this.booktrainsession.UseVisualStyleBackColor = true;
            this.booktrainsession.Click += new System.EventHandler(this.booktrainsession_Click);
            this.Book_Training_Session.Location = new System.Drawing.Point(225, 421);
            this.Book_Training_Session.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Book_Training_Session.Name = "Book_Training_Session";
            this.Book_Training_Session.Size = new System.Drawing.Size(333, 34);
            this.Book_Training_Session.TabIndex = 9;
            this.Book_Training_Session.Text = "Book Training session";
            this.Book_Training_Session.UseVisualStyleBackColor = true;
            this.Book_Training_Session.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Football",
            "Padel"});
            this.comboBox4.Location = new System.Drawing.Point(169, 276);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(250, 24);
            this.comboBox4.TabIndex = 10;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            this.Available_comboBox4.Location = new System.Drawing.Point(225, 340);
            this.Available_comboBox4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Available_comboBox4.Name = "Available_comboBox4";
            this.Available_comboBox4.Size = new System.Drawing.Size(332, 24);
            this.Available_comboBox4.TabIndex = 10;
            this.Available_comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Available Trainers";
            this.Available_Trainers.AutoSize = true;
            this.Available_Trainers.Location = new System.Drawing.Point(53, 343);
            this.Available_Trainers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Available_Trainers.Name = "Available_Trainers";
            this.Available_Trainers.Size = new System.Drawing.Size(117, 16);
            this.Available_Trainers.TabIndex = 11;
            this.Available_Trainers.Text = "Available Trainers";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(484, 208);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(340, 34);
            this.button3.TabIndex = 12;
            this.button3.Text = "Cancelling Court Booking";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // Cancelling_Bookings
            // 
            this.button4.Location = new System.Drawing.Point(484, 140);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(340, 34);
            this.button4.TabIndex = 13;
            this.button4.Text = "Cancelling Bookings";
            this.button4.UseVisualStyleBackColor = true;
            this.Cancelling_Bookings.Location = new System.Drawing.Point(645, 172);
            this.Cancelling_Bookings.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Cancelling_Bookings.Name = "Cancelling_Bookings";
            this.Cancelling_Bookings.Size = new System.Drawing.Size(453, 42);
            this.Cancelling_Bookings.TabIndex = 13;
            this.Cancelling_Bookings.Text = "Cancelling Bookings";
            this.Cancelling_Bookings.UseVisualStyleBackColor = true;
            this.Cancelling_Bookings.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(484, 73);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(340, 34);
            this.button5.TabIndex = 14;
            this.button5.Text = "Cancelling Tournament Participation";
            this.button5.UseVisualStyleBackColor = true;
            this.Cancelling_tournament_Participation.Location = new System.Drawing.Point(645, 90);
            this.Cancelling_tournament_Participation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Cancelling_tournament_Participation.Name = "Cancelling_tournament_Participation";
            this.Cancelling_tournament_Participation.Size = new System.Drawing.Size(453, 42);
            this.Cancelling_tournament_Participation.TabIndex = 14;
            this.Cancelling_tournament_Participation.Text = "Cancelling Tournament Participation";
            this.Cancelling_tournament_Participation.UseVisualStyleBackColor = true;
            this.Cancelling_tournament_Participation.Click += new System.EventHandler(this.Cancelling_tournament_Participation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(946, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "My Account";
            this.My_Account.AutoSize = true;
            this.My_Account.Location = new System.Drawing.Point(1261, 127);
            this.My_Account.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.My_Account.Name = "My_Account";
            this.My_Account.Size = new System.Drawing.Size(76, 16);
            this.My_Account.TabIndex = 13;
            this.My_Account.Text = "My Account";
            this.My_Account.Click += new System.EventHandler(this.label6_Click);
            // 
            // trainingsessionold
            // 
            this.trainingsessionold.Location = new System.Drawing.Point(484, 398);
            this.trainingsessionold.Margin = new System.Windows.Forms.Padding(4);
            this.trainingsessionold.Location = new System.Drawing.Point(652, 488);
            this.trainingsessionold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trainingsessionold.Name = "trainingsessionold";
            this.trainingsessionold.Size = new System.Drawing.Size(340, 34);
            this.trainingsessionold.Size = new System.Drawing.Size(247, 34);
            this.trainingsessionold.TabIndex = 12;
            this.trainingsessionold.Text = "Your Training Sessions";
            this.trainingsessionold.UseVisualStyleBackColor = true;
            this.trainingsessionold.Click += new System.EventHandler(this.trainingsessionold_Click);
            // 
            // courtbookingold
            // 
            this.courtbookingold.Location = new System.Drawing.Point(484, 339);
            this.courtbookingold.Margin = new System.Windows.Forms.Padding(4);
            this.courtbookingold.Location = new System.Drawing.Point(652, 421);
            this.courtbookingold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courtbookingold.Name = "courtbookingold";
            this.courtbookingold.Size = new System.Drawing.Size(340, 34);
            this.courtbookingold.Size = new System.Drawing.Size(247, 34);
            this.courtbookingold.TabIndex = 13;
            this.courtbookingold.Text = "Your Court Bookings";
            this.courtbookingold.UseVisualStyleBackColor = true;
            this.courtbookingold.Click += new System.EventHandler(this.courtbookingold_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(484, 282);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(340, 34);
            this.button6.TabIndex = 15;
            this.button6.Text = "Upcoming Tournament";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Ccomplaint
            // 
            this.Ccomplaint.Location = new System.Drawing.Point(484, 457);
            this.Ccomplaint.Margin = new System.Windows.Forms.Padding(4);
            this.Ccomplaint.Name = "Ccomplaint";
            this.Ccomplaint.Size = new System.Drawing.Size(340, 34);
            this.Ccomplaint.TabIndex = 16;
            this.Ccomplaint.Text = "Complaint about a court";
            this.Ccomplaint.UseVisualStyleBackColor = true;
            this.Ccomplaint.Click += new System.EventHandler(this.Ccomplaint_Click);
            // 
            // Tcomplaint
            // 
            this.Tcomplaint.Location = new System.Drawing.Point(484, 515);
            this.Tcomplaint.Margin = new System.Windows.Forms.Padding(4);
            this.Tcomplaint.Name = "Tcomplaint";
            this.Tcomplaint.Size = new System.Drawing.Size(340, 34);
            this.Tcomplaint.TabIndex = 17;
            this.Tcomplaint.Text = "Complain about a Trainer";
            this.Tcomplaint.UseVisualStyleBackColor = true;
            this.Tcomplaint.Click += new System.EventHandler(this.Tcomplaint_Click);
            this.Upcoming_Tournament.Location = new System.Drawing.Point(652, 340);
            this.Upcoming_Tournament.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Upcoming_Tournament.Name = "Upcoming_Tournament";
            this.Upcoming_Tournament.Size = new System.Drawing.Size(254, 42);
            this.Upcoming_Tournament.TabIndex = 15;
            this.Upcoming_Tournament.Text = "Availabe Tournaments";
            this.Upcoming_Tournament.UseVisualStyleBackColor = true;
            this.Upcoming_Tournament.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ehgezly.Properties.Resources.my_account;
            this.pictureBox1.Location = new System.Drawing.Point(926, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.Profile.Image = global::Ehgezly.Properties.Resources.my_account;
            this.Profile.Location = new System.Drawing.Point(1235, 27);
            this.Profile.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(156, 92);
            this.Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile.TabIndex = 12;
            this.Profile.TabStop = false;
            this.Profile.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Player_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 574);
            this.Controls.Add(this.Tcomplaint);
            this.Controls.Add(this.Ccomplaint);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.ClientSize = new System.Drawing.Size(1423, 552);
            this.Controls.Add(this.Upcoming_Tournament);
            this.Controls.Add(this.Cancelling_tournament_Participation);
            this.Controls.Add(this.Cancelling_Bookings);
            this.Controls.Add(this.My_Account);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.courtbookingold);
            this.Controls.Add(this.trainingsessionold);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.booktrainsession);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bookcourt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Controls.Add(this.Court_Name);
            this.Controls.Add(this.Court_Name_comboBox3);
            this.Controls.Add(this.Court_Loc);
            this.Controls.Add(this.Sport_Type);
            this.Controls.Add(this.Sport_Type_Combobox);
            this.Controls.Add(this.Court_Loc_comboBox1);
            this.Controls.Add(this.Book_Court);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Player_Homepage";
            this.Text = "Player_Homepage";
            this.Load += new System.EventHandler(this.Player_Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bookcourt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button booktrainsession;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Booking_Time;
        private System.Windows.Forms.Button Book_Training_Session;
        private System.Windows.Forms.ComboBox Available_comboBox4;
        private System.Windows.Forms.Label Available_Trainers;
        private System.Windows.Forms.Button Cancelling_Bookings;
        private System.Windows.Forms.Button Cancelling_tournament_Participation;
        private System.Windows.Forms.Label My_Account;
        private System.Windows.Forms.PictureBox Profile;
        private System.Windows.Forms.Button trainingsessionold;
        private System.Windows.Forms.Button courtbookingold;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Ccomplaint;
        private System.Windows.Forms.Button Tcomplaint;
    }
}