namespace Ehgezly
{
    partial class TournamentsReportForm
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
            this.NoTrainersButton = new System.Windows.Forms.Button();
            this.NoPlayersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoTrainersButton
            // 
            this.NoTrainersButton.Location = new System.Drawing.Point(45, 216);
            this.NoTrainersButton.Name = "NoTrainersButton";
            this.NoTrainersButton.Size = new System.Drawing.Size(336, 38);
            this.NoTrainersButton.TabIndex = 5;
            this.NoTrainersButton.Text = "Number of Trainers";
            this.NoTrainersButton.UseVisualStyleBackColor = true;
            this.NoTrainersButton.Click += new System.EventHandler(this.NoTrainersButton_Click);
            // 
            // NoPlayersButton
            // 
            this.NoPlayersButton.Location = new System.Drawing.Point(45, 54);
            this.NoPlayersButton.Name = "NoPlayersButton";
            this.NoPlayersButton.Size = new System.Drawing.Size(336, 38);
            this.NoPlayersButton.TabIndex = 4;
            this.NoPlayersButton.Text = "Number of players";
            this.NoPlayersButton.UseVisualStyleBackColor = true;
            this.NoPlayersButton.Click += new System.EventHandler(this.NoPlayersButton_Click);
            // 
            // TournamentsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.NoTrainersButton);
            this.Controls.Add(this.NoPlayersButton);
            this.Name = "TournamentsReportForm";
            this.Text = "TournamentsReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NoTrainersButton;
        private System.Windows.Forms.Button NoPlayersButton;
    }
}