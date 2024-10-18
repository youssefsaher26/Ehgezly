namespace Ehgezly
{
    partial class Tournaments_Trainer_Upcoming
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
            this.tournamenttrainingaupcominggridview = new System.Windows.Forms.DataGridView();
            this.jointournamenttrainer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tournamenttrainingaupcominggridview)).BeginInit();
            this.SuspendLayout();
            // 
            // tournamenttrainingaupcominggridview
            // 
            this.tournamenttrainingaupcominggridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tournamenttrainingaupcominggridview.Location = new System.Drawing.Point(62, 73);
            this.tournamenttrainingaupcominggridview.Margin = new System.Windows.Forms.Padding(4);
            this.tournamenttrainingaupcominggridview.Name = "tournamenttrainingaupcominggridview";
            this.tournamenttrainingaupcominggridview.RowHeadersWidth = 51;
            this.tournamenttrainingaupcominggridview.Size = new System.Drawing.Size(671, 260);
            this.tournamenttrainingaupcominggridview.TabIndex = 1;
            this.tournamenttrainingaupcominggridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tournamenttrainingaupcominggridview_CellContentClick);
            // 
            // jointournamenttrainer
            // 
            this.jointournamenttrainer.Location = new System.Drawing.Point(319, 378);
            this.jointournamenttrainer.Name = "jointournamenttrainer";
            this.jointournamenttrainer.Size = new System.Drawing.Size(150, 41);
            this.jointournamenttrainer.TabIndex = 2;
            this.jointournamenttrainer.Text = "join";
            this.jointournamenttrainer.UseVisualStyleBackColor = true;
            this.jointournamenttrainer.Click += new System.EventHandler(this.jointournamenttrainer_Click);
            // 
            // Tournaments_Trainer_Upcoming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jointournamenttrainer);
            this.Controls.Add(this.tournamenttrainingaupcominggridview);
            this.Name = "Tournaments_Trainer_Upcoming";
            this.Text = "Tournaments_Trainer_Upcoming";
            this.Load += new System.EventHandler(this.Tournaments_Trainer_Upcoming_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tournamenttrainingaupcominggridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tournamenttrainingaupcominggridview;
        private System.Windows.Forms.Button jointournamenttrainer;
    }
}