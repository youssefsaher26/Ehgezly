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
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.oldmnrequests = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "My Account";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ehgezly.Properties.Resources.my_account;
            this.pictureBox1.Location = new System.Drawing.Point(660, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // oldmnrequests
            // 
            this.oldmnrequests.Location = new System.Drawing.Point(44, 68);
            this.oldmnrequests.Name = "oldmnrequests";
            this.oldmnrequests.Size = new System.Drawing.Size(233, 29);
            this.oldmnrequests.TabIndex = 0;
            this.oldmnrequests.Text = "Old maintenance requests";
            this.oldmnrequests.UseVisualStyleBackColor = true;
            this.oldmnrequests.Click += new System.EventHandler(this.oldmnrequests_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Court Complaints";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manager_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.oldmnrequests);
            this.Name = "Manager_Homepage";
            this.Text = "Manager_Homepage";
            this.Load += new System.EventHandler(this.Manager_Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button oldmnrequests;
        private System.Windows.Forms.Button button1;
    }
}