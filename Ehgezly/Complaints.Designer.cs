namespace Ehgezly
{
    partial class Complaints
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
            this.dataGridView14143 = new System.Windows.Forms.DataGridView();
            this.button35534 = new System.Windows.Forms.Button();
            this.richTextBox1392 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView14143)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView14143
            // 
            this.dataGridView14143.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView14143.Location = new System.Drawing.Point(27, 32);
            this.dataGridView14143.Name = "dataGridView14143";
            this.dataGridView14143.RowHeadersWidth = 51;
            this.dataGridView14143.RowTemplate.Height = 24;
            this.dataGridView14143.Size = new System.Drawing.Size(375, 379);
            this.dataGridView14143.TabIndex = 0;
            this.dataGridView14143.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView14143_CellContentClick);
            // 
            // button35534
            // 
            this.button35534.Location = new System.Drawing.Point(444, 302);
            this.button35534.Name = "button35534";
            this.button35534.Size = new System.Drawing.Size(279, 47);
            this.button35534.TabIndex = 1;
            this.button35534.Text = "Submit Complaint";
            this.button35534.UseVisualStyleBackColor = true;
            this.button35534.Click += new System.EventHandler(this.button35534_Click);
            // 
            // richTextBox1392
            // 
            this.richTextBox1392.Location = new System.Drawing.Point(431, 85);
            this.richTextBox1392.Name = "richTextBox1392";
            this.richTextBox1392.Size = new System.Drawing.Size(311, 118);
            this.richTextBox1392.TabIndex = 2;
            this.richTextBox1392.Text = "";
            // 
            // Complaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1392);
            this.Controls.Add(this.button35534);
            this.Controls.Add(this.dataGridView14143);
            this.Name = "Complaints";
            this.Text = "Complaints";
            this.Load += new System.EventHandler(this.Complaints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView14143)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView14143;
        private System.Windows.Forms.RichTextBox richTextBox1392;
        private System.Windows.Forms.Button button35534;
    
    }
}