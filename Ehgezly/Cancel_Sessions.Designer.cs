namespace Ehgezly
{
    partial class Cancel_Sessions
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
            this.cancelsession = new System.Windows.Forms.Button();
            this.cancelsessiongridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cancelsessiongridview)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelsession
            // 
            this.cancelsession.Location = new System.Drawing.Point(297, 346);
            this.cancelsession.Margin = new System.Windows.Forms.Padding(4);
            this.cancelsession.Name = "cancelsession";
            this.cancelsession.Size = new System.Drawing.Size(196, 42);
            this.cancelsession.TabIndex = 3;
            this.cancelsession.Text = "Cancel Session";
            this.cancelsession.UseVisualStyleBackColor = true;
            this.cancelsession.Click += new System.EventHandler(this.cancelsession_Click);
            // 
            // cancelsessiongridview
            // 
            this.cancelsessiongridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cancelsessiongridview.Location = new System.Drawing.Point(73, 62);
            this.cancelsessiongridview.Margin = new System.Windows.Forms.Padding(4);
            this.cancelsessiongridview.Name = "cancelsessiongridview";
            this.cancelsessiongridview.RowHeadersWidth = 51;
            this.cancelsessiongridview.Size = new System.Drawing.Size(655, 252);
            this.cancelsessiongridview.TabIndex = 2;
            // 
            // Cancel_Sessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelsession);
            this.Controls.Add(this.cancelsessiongridview);
            this.Name = "Cancel_Sessions";
            this.Text = "Cancel_Sessions";
            ((System.ComponentModel.ISupportInitialize)(this.cancelsessiongridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelsession;
        private System.Windows.Forms.DataGridView cancelsessiongridview;
    }
}