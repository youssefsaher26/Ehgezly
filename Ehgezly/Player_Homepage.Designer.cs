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
            this.Book_Court = new System.Windows.Forms.Button();
            this.Court_Loc_comboBox1 = new System.Windows.Forms.ComboBox();
            this.Sport_Type_Combobox = new System.Windows.Forms.ComboBox();
            this.Sport_Type = new System.Windows.Forms.Label();
            this.Court_Loc = new System.Windows.Forms.Label();
            this.Court_Name_comboBox3 = new System.Windows.Forms.ComboBox();
            this.Court_Name = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Booking_Time = new System.Windows.Forms.Label();
            this.Book_Training_Session = new System.Windows.Forms.Button();
            this.Available_comboBox4 = new System.Windows.Forms.ComboBox();
            this.Available_Trainers = new System.Windows.Forms.Label();
            this.Cancelling_Court_Booking = new System.Windows.Forms.Button();
            this.Cancelling_Bookings = new System.Windows.Forms.Button();
            this.Cancelling_tournament_Participation = new System.Windows.Forms.Button();
            this.My_Account = new System.Windows.Forms.Label();
            this.trainingsessionold = new System.Windows.Forms.Button();
            this.courtbookingold = new System.Windows.Forms.Button();
            this.Upcoming_Tournament = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // Book_Court
            // 
            this.Book_Court.Location = new System.Drawing.Point(169, 398);
            this.Book_Court.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Book_Court.Name = "Book_Court";
            this.Book_Court.Size = new System.Drawing.Size(250, 28);
            this.Book_Court.TabIndex = 0;
            this.Book_Court.Text = "Book Court";
            this.Book_Court.UseVisualStyleBackColor = true;
            this.Book_Court.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Court_Loc_comboBox1
            // 
            this.Court_Loc_comboBox1.FormattingEnabled = true;
            this.Court_Loc_comboBox1.Location = new System.Drawing.Point(169, 118);
            this.Court_Loc_comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Court_Loc_comboBox1.Name = "Court_Loc_comboBox1";
            this.Court_Loc_comboBox1.Size = new System.Drawing.Size(250, 24);
            this.Court_Loc_comboBox1.TabIndex = 1;
            this.Court_Loc_comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Sport_Type_Combobox
            // 
            this.Sport_Type_Combobox.FormattingEnabled = true;
            this.Sport_Type_Combobox.Items.AddRange(new object[] {
            "Football",
            "Padel"});
            this.Sport_Type_Combobox.Location = new System.Drawing.Point(169, 73);
            this.Sport_Type_Combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sport_Type_Combobox.Name = "Sport_Type_Combobox";
            this.Sport_Type_Combobox.Size = new System.Drawing.Size(250, 24);
            this.Sport_Type_Combobox.TabIndex = 2;
            this.Sport_Type_Combobox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Sport_Type
            // 
            this.Sport_Type.AutoSize = true;
            this.Sport_Type.Location = new System.Drawing.Point(42, 77);
            this.Sport_Type.Name = "Sport_Type";
            this.Sport_Type.Size = new System.Drawing.Size(74, 16);
            this.Sport_Type.TabIndex = 3;
            this.Sport_Type.Text = "Sport Type";
            this.Sport_Type.Click += new System.EventHandler(this.label1_Click);
            // 
            // Court_Loc
            // 
            this.Court_Loc.AutoSize = true;
            this.Court_Loc.Location = new System.Drawing.Point(40, 121);
            this.Court_Loc.Name = "Court_Loc";
            this.Court_Loc.Size = new System.Drawing.Size(92, 16);
            this.Court_Loc.TabIndex = 4;
            this.Court_Loc.Text = "Court Location";
            // 
            // Court_Name_comboBox3
            // 
            this.Court_Name_comboBox3.FormattingEnabled = true;
            this.Court_Name_comboBox3.Items.AddRange(new object[] {
            "Football",
            "Padel"});
            this.Court_Name_comboBox3.Location = new System.Drawing.Point(169, 169);
            this.Court_Name_comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Court_Name_comboBox3.Name = "Court_Name_comboBox3";
            this.Court_Name_comboBox3.Size = new System.Drawing.Size(250, 24);
            this.Court_Name_comboBox3.TabIndex = 5;
            // 
            // Court_Name
            // 
            this.Court_Name.AutoSize = true;
            this.Court_Name.Location = new System.Drawing.Point(44, 173);
            this.Court_Name.Name = "Court_Name";
            this.Court_Name.Size = new System.Drawing.Size(78, 16);
            this.Court_Name.TabIndex = 6;
            this.Court_Name.Text = "Court Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 219);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Booking_Time
            // 
            this.Booking_Time.AutoSize = true;
            this.Booking_Time.Location = new System.Drawing.Point(42, 224);
            this.Booking_Time.Name = "Booking_Time";
            this.Booking_Time.Size = new System.Drawing.Size(91, 16);
            this.Booking_Time.TabIndex = 8;
            this.Booking_Time.Text = "Booking Time";
            // 
            // Book_Training_Session
            // 
            this.Book_Training_Session.Location = new System.Drawing.Point(169, 342);
            this.Book_Training_Session.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Book_Training_Session.Name = "Book_Training_Session";
            this.Book_Training_Session.Size = new System.Drawing.Size(250, 28);
            this.Book_Training_Session.TabIndex = 9;
            this.Book_Training_Session.Text = "Book Training session";
            this.Book_Training_Session.UseVisualStyleBackColor = true;
            this.Book_Training_Session.Click += new System.EventHandler(this.button2_Click);
            // 
            // Available_comboBox4
            // 
            this.Available_comboBox4.FormattingEnabled = true;
            this.Available_comboBox4.Items.AddRange(new object[] {
            "Football",
            "Padel"});
            this.Available_comboBox4.Location = new System.Drawing.Point(169, 276);
            this.Available_comboBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Available_comboBox4.Name = "Available_comboBox4";
            this.Available_comboBox4.Size = new System.Drawing.Size(250, 24);
            this.Available_comboBox4.TabIndex = 10;
            this.Available_comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // Available_Trainers
            // 
            this.Available_Trainers.AutoSize = true;
            this.Available_Trainers.Location = new System.Drawing.Point(40, 279);
            this.Available_Trainers.Name = "Available_Trainers";
            this.Available_Trainers.Size = new System.Drawing.Size(117, 16);
            this.Available_Trainers.TabIndex = 11;
            this.Available_Trainers.Text = "Available Trainers";
            // 
            // Cancelling_Court_Booking
            // 
            this.Cancelling_Court_Booking.Location = new System.Drawing.Point(484, 208);
            this.Cancelling_Court_Booking.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelling_Court_Booking.Name = "Cancelling_Court_Booking";
            this.Cancelling_Court_Booking.Size = new System.Drawing.Size(340, 34);
            this.Cancelling_Court_Booking.TabIndex = 12;
            this.Cancelling_Court_Booking.Text = "Cancelling Court Booking";
            this.Cancelling_Court_Booking.UseVisualStyleBackColor = true;
            this.Cancelling_Court_Booking.Click += new System.EventHandler(this.button3_Click);
            // 
            // Cancelling_Bookings
            // 
            this.Cancelling_Bookings.Location = new System.Drawing.Point(484, 140);
            this.Cancelling_Bookings.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelling_Bookings.Name = "Cancelling_Bookings";
            this.Cancelling_Bookings.Size = new System.Drawing.Size(340, 34);
            this.Cancelling_Bookings.TabIndex = 13;
            this.Cancelling_Bookings.Text = "Cancelling Bookings";
            this.Cancelling_Bookings.UseVisualStyleBackColor = true;
            this.Cancelling_Bookings.Click += new System.EventHandler(this.button4_Click);
            // 
            // Cancelling_tournament_Participation
            // 
            this.Cancelling_tournament_Participation.Location = new System.Drawing.Point(484, 73);
            this.Cancelling_tournament_Participation.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelling_tournament_Participation.Name = "Cancelling_tournament_Participation";
            this.Cancelling_tournament_Participation.Size = new System.Drawing.Size(340, 34);
            this.Cancelling_tournament_Participation.TabIndex = 14;
            this.Cancelling_tournament_Participation.Text = "Cancelling Tournament Participation";
            this.Cancelling_tournament_Participation.UseVisualStyleBackColor = true;
            // 
            // My_Account
            // 
            this.My_Account.AutoSize = true;
            this.My_Account.Location = new System.Drawing.Point(946, 103);
            this.My_Account.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.trainingsessionold.Name = "trainingsessionold";
            this.trainingsessionold.Size = new System.Drawing.Size(340, 34);
            this.trainingsessionold.TabIndex = 12;
            this.trainingsessionold.Text = "Old Training Sessions";
            this.trainingsessionold.UseVisualStyleBackColor = true;
            this.trainingsessionold.Click += new System.EventHandler(this.trainingsessionold_Click);
            // 
            // courtbookingold
            // 
            this.courtbookingold.Location = new System.Drawing.Point(484, 339);
            this.courtbookingold.Margin = new System.Windows.Forms.Padding(4);
            this.courtbookingold.Name = "courtbookingold";
            this.courtbookingold.Size = new System.Drawing.Size(340, 34);
            this.courtbookingold.TabIndex = 13;
            this.courtbookingold.Text = "Old Court Bookings";
            this.courtbookingold.UseVisualStyleBackColor = true;
            this.courtbookingold.Click += new System.EventHandler(this.courtbookingold_Click);
            // 
            // Upcoming_Tournament
            // 
            this.Upcoming_Tournament.Location = new System.Drawing.Point(484, 282);
            this.Upcoming_Tournament.Margin = new System.Windows.Forms.Padding(4);
            this.Upcoming_Tournament.Name = "Upcoming_Tournament";
            this.Upcoming_Tournament.Size = new System.Drawing.Size(340, 34);
            this.Upcoming_Tournament.TabIndex = 15;
            this.Upcoming_Tournament.Text = "Upcoming Tournament";
            this.Upcoming_Tournament.UseVisualStyleBackColor = true;
            this.Upcoming_Tournament.Click += new System.EventHandler(this.button6_Click);
            // 
            // Profile
            // 
            this.Profile.Image = global::Ehgezly.Properties.Resources.my_account;
            this.Profile.Location = new System.Drawing.Point(926, 22);
            this.Profile.Margin = new System.Windows.Forms.Padding(4);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(117, 75);
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
            this.Controls.Add(this.Upcoming_Tournament);
            this.Controls.Add(this.Cancelling_tournament_Participation);
            this.Controls.Add(this.Cancelling_Bookings);
            this.Controls.Add(this.Cancelling_Court_Booking);
            this.Controls.Add(this.My_Account);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.courtbookingold);
            this.Controls.Add(this.trainingsessionold);
            this.Controls.Add(this.Available_Trainers);
            this.Controls.Add(this.Available_comboBox4);
            this.Controls.Add(this.Book_Training_Session);
            this.Controls.Add(this.Booking_Time);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Court_Name);
            this.Controls.Add(this.Court_Name_comboBox3);
            this.Controls.Add(this.Court_Loc);
            this.Controls.Add(this.Sport_Type);
            this.Controls.Add(this.Sport_Type_Combobox);
            this.Controls.Add(this.Court_Loc_comboBox1);
            this.Controls.Add(this.Book_Court);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Player_Homepage";
            this.Text = "Player_Homepage";
            this.Load += new System.EventHandler(this.Player_Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Book_Court;
        private System.Windows.Forms.ComboBox Court_Loc_comboBox1;
        private System.Windows.Forms.ComboBox Sport_Type_Combobox;
        private System.Windows.Forms.Label Sport_Type;
        private System.Windows.Forms.Label Court_Loc;
        private System.Windows.Forms.ComboBox Court_Name_comboBox3;
        private System.Windows.Forms.Label Court_Name;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Booking_Time;
        private System.Windows.Forms.Button Book_Training_Session;
        private System.Windows.Forms.ComboBox Available_comboBox4;
        private System.Windows.Forms.Label Available_Trainers;
        private System.Windows.Forms.Button Cancelling_Court_Booking;
        private System.Windows.Forms.Button Cancelling_Bookings;
        private System.Windows.Forms.Button Cancelling_tournament_Participation;
        private System.Windows.Forms.Label My_Account;
        private System.Windows.Forms.PictureBox Profile;
        private System.Windows.Forms.Button trainingsessionold;
        private System.Windows.Forms.Button courtbookingold;
        private System.Windows.Forms.Button Upcoming_Tournament;
    }
}