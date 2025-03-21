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
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChantier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChantier
            // 
            this.dgvChantier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChantier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Adresse,
            this.DateDebut,
            this.DateFin});
            this.dgvChantier.Location = new System.Drawing.Point(39, 53);
            this.dgvChantier.Name = "dgvChantier";
            this.dgvChantier.ReadOnly = true;
            this.dgvChantier.RowHeadersWidth = 51;
            this.dgvChantier.RowTemplate.Height = 24;
            this.dgvChantier.Size = new System.Drawing.Size(628, 344);
            this.dgvChantier.TabIndex = 2;
            this.dgvChantier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChantier_CellContentClick);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 125;
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.MinimumWidth = 6;
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            this.Adresse.Width = 125;
            // 
            // DateDebut
            // 
            this.DateDebut.HeaderText = "DateDebut";
            this.DateDebut.MinimumWidth = 6;
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.ReadOnly = true;
            this.DateDebut.Width = 125;
            // 
            // DateFin
            // 
            this.DateFin.HeaderText = "DateFin";
            this.DateFin.MinimumWidth = 6;
            this.DateFin.Name = "DateFin";
            this.DateFin.ReadOnly = true;
            this.DateFin.Width = 125;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(39, 16);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FmrGestionChantier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvChantier);
            this.Controls.Add(this.btnAjouter);
            this.Name = "FmrGestionChantier";
            this.Text = "FmrGestionChantier";
            this.Load += new System.EventHandler(this.FmrGestionChantier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChantier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChantier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFin;
    }
}