namespace Ehgezly
{
    partial class Tournaments_Trainer
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
            this.canceltournament = new System.Windows.Forms.Button();
            this.tournamentstrainergridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentstrainergridview)).BeginInit();
            this.SuspendLayout();
            // 
            // canceltournament
            // 
            this.canceltournament.Location = new System.Drawing.Point(282, 340);
            this.canceltournament.Margin = new System.Windows.Forms.Padding(4);
            this.canceltournament.Name = "canceltournament";
            this.canceltournament.Size = new System.Drawing.Size(209, 49);
            this.canceltournament.TabIndex = 3;
            this.canceltournament.Text = "Cancel Tournaments";
            this.canceltournament.UseVisualStyleBackColor = true;
            this.canceltournament.Click += new System.EventHandler(this.canceltournament_Click);
            // 
            // tournamentstrainergridview
            // 
            this.tournamentstrainergridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tournamentstrainergridview.Location = new System.Drawing.Point(90, 62);
            this.tournamentstrainergridview.Margin = new System.Windows.Forms.Padding(4);
            this.tournamentstrainergridview.Name = "tournamentstrainergridview";
            this.tournamentstrainergridview.RowHeadersWidth = 51;
            this.tournamentstrainergridview.Size = new System.Drawing.Size(608, 247);
            this.tournamentstrainergridview.TabIndex = 2;
            // 
            // Tournaments_Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canceltournament);
            this.Controls.Add(this.tournamentstrainergridview);
            this.Name = "Tournaments_Trainer";
            this.Text = "Tournaments_Trainer";
            ((System.ComponentModel.ISupportInitialize)(this.tournamentstrainergridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button canceltournament;
        private System.Windows.Forms.DataGridView tournamentstrainergridview;
    }
}