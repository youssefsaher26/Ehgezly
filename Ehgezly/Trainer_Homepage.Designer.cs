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
            this.label1 = new System.Windows.Forms.Label();
            this.oldtrainingsessions = new System.Windows.Forms.Button();
            this.Ccomplaint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
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
            // Ccomplaint
            // 
            this.Ccomplaint.Location = new System.Drawing.Point(547, 393);
            this.Ccomplaint.Margin = new System.Windows.Forms.Padding(4);
            this.Ccomplaint.Name = "Ccomplaint";
            this.Ccomplaint.Size = new System.Drawing.Size(216, 30);
            this.Ccomplaint.TabIndex = 17;
            this.Ccomplaint.Text = "Complaint about a court";
            this.Ccomplaint.UseVisualStyleBackColor = true;
            this.Ccomplaint.Click += new System.EventHandler(this.Ccomplaint_Click);
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
            this.Controls.Add(this.Ccomplaint);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oldtrainingsessions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Trainer_Homepage";
            this.Text = "Trainer_Homepage";
            this.Load += new System.EventHandler(this.Trainer_Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button oldtrainingsessions;
        private System.Windows.Forms.Button Ccomplaint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}