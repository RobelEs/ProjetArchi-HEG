namespace ProjetArchi
{
    partial class FmrGestionChantier
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
            this.dgvChantier = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChantier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChantier
            // 
            this.dgvChantier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChantier.Location = new System.Drawing.Point(65, 22);
            this.dgvChantier.Name = "dgvChantier";
            this.dgvChantier.RowHeadersWidth = 51;
            this.dgvChantier.RowTemplate.Height = 24;
            this.dgvChantier.Size = new System.Drawing.Size(952, 609);
            this.dgvChantier.TabIndex = 0;
            this.dgvChantier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChantier_CellContentClick);
            // 
            // FmrGestionChantier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 671);
            this.Controls.Add(this.dgvChantier);
            this.Name = "FmrGestionChantier";
            this.Text = "FmrGestionChantier";
            this.Load += new System.EventHandler(this.FmrGestionChantier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChantier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChantier;
    }
}