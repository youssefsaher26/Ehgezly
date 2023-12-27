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
            this.oldmnrequests = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldmnrequests
            // 
            this.oldmnrequests.Location = new System.Drawing.Point(517, 356);
            this.oldmnrequests.Name = "oldmnrequests";
            this.oldmnrequests.Size = new System.Drawing.Size(233, 29);
            this.oldmnrequests.TabIndex = 0;
            this.oldmnrequests.Text = "Old maintenance requests";
            this.oldmnrequests.UseVisualStyleBackColor = true;
            this.oldmnrequests.Click += new System.EventHandler(this.oldmnrequests_Click);
            // 
            // Manager_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oldmnrequests);
            this.Name = "Manager_Homepage";
            this.Text = "Manager_Homepage";
            this.Load += new System.EventHandler(this.Manager_Homepage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button oldmnrequests;
    }
}