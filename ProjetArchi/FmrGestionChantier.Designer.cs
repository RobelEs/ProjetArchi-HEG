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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.trier = new System.Windows.Forms.TextBox();
            this.cmbTri = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChantier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChantier
            // 
            this.dgvChantier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChantier.Location = new System.Drawing.Point(82, 69);
            this.dgvChantier.Name = "dgvChantier";
            this.dgvChantier.RowHeadersWidth = 51;
            this.dgvChantier.RowTemplate.Height = 24;
            this.dgvChantier.Size = new System.Drawing.Size(935, 562);
            this.dgvChantier.TabIndex = 0;
            this.dgvChantier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChantier_CellContentClick);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(82, 29);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // trier
            // 
            this.trier.Location = new System.Drawing.Point(884, 29);
            this.trier.Name = "trier";
            this.trier.Size = new System.Drawing.Size(100, 22);
            this.trier.TabIndex = 3;
            this.trier.TextChanged += new System.EventHandler(this.trier_TextChanged);
            // 
            // cmbTri
            // 
            this.cmbTri.FormattingEnabled = true;
            this.cmbTri.Items.AddRange(new object[] {
            "Name",
            "Address",
            "StartDate",
            "EndDate",
            "ClientId"});
            this.cmbTri.Location = new System.Drawing.Point(663, 29);
            this.cmbTri.Name = "cmbTri";
            this.cmbTri.Size = new System.Drawing.Size(121, 24);
            this.cmbTri.TabIndex = 5;
            this.cmbTri.SelectedIndexChanged += new System.EventHandler(this.cmbTri_SelectedIndexChanged);
            // 
            // FmrGestionChantier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 671);
            this.Controls.Add(this.cmbTri);
            this.Controls.Add(this.trier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvChantier);
            this.Name = "FmrGestionChantier";
            this.Text = "FmrGestionChantier";
            this.Load += new System.EventHandler(this.FmrGestionChantier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChantier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChantier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox trier;
        private System.Windows.Forms.ComboBox cmbTri;
    }
}