namespace Ehgezly
{
    partial class Cancel_Tournament
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
            this.Canceltour = new System.Windows.Forms.Button();
            this.Canceltourgridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Canceltourgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Canceltour
            // 
            this.Canceltour.Location = new System.Drawing.Point(299, 343);
            this.Canceltour.Margin = new System.Windows.Forms.Padding(4);
            this.Canceltour.Name = "Canceltour";
            this.Canceltour.Size = new System.Drawing.Size(191, 43);
            this.Canceltour.TabIndex = 3;
            this.Canceltour.Text = "Cancel Your Participation";
            this.Canceltour.UseVisualStyleBackColor = true;
            this.Canceltour.Click += new System.EventHandler(this.Canceltour_Click);
            // 
            // Canceltourgridview
            // 
            this.Canceltourgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Canceltourgridview.Location = new System.Drawing.Point(70, 65);
            this.Canceltourgridview.Margin = new System.Windows.Forms.Padding(4);
            this.Canceltourgridview.Name = "Canceltourgridview";
            this.Canceltourgridview.RowHeadersWidth = 51;
            this.Canceltourgridview.Size = new System.Drawing.Size(660, 241);
            this.Canceltourgridview.TabIndex = 2;
            // 
            // Cancel_Tournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Canceltour);
            this.Controls.Add(this.Canceltourgridview);
            this.Name = "Cancel_Tournament";
            this.Text = "Cancel_Tournament";
            ((System.ComponentModel.ISupportInitialize)(this.Canceltourgridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Canceltour;
        private System.Windows.Forms.DataGridView Canceltourgridview;
    }
}