namespace ProjetArchi
{
    partial class FrmModifierEmploye
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnValider;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNom.Location = new System.Drawing.Point(50, 50);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 19);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "&Nom:";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPrenom.Location = new System.Drawing.Point(50, 100);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(71, 19);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom:";
            this.lblPrenom.Click += new System.EventHandler(this.lblPrenom_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Arial", 10F);
            this.lblRole.Location = new System.Drawing.Point(50, 150);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 19);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Rôle:";
            this.lblRole.Click += new System.EventHandler(this.lblRole_Click);
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNom.Location = new System.Drawing.Point(150, 46);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 27);
            this.txtNom.TabIndex = 1;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPrenom.Location = new System.Drawing.Point(150, 96);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(200, 27);
            this.txtPrenom.TabIndex = 3;
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtPrenom_TextChanged);
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("Arial", 10F);
            this.txtRole.Location = new System.Drawing.Point(150, 146);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(200, 27);
            this.txtRole.TabIndex = 5;
            this.txtRole.TextChanged += new System.EventHandler(this.txtRole_TextChanged);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnValider.Font = new System.Drawing.Font("Arial", 10F);
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(150, 234);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(200, 30);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "&Modifier";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(150, 270);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(200, 30);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAjouter.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(150, 189);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(200, 30);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FrmModifierEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(482, 343);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.MinimumSize = new System.Drawing.Size(385, 285);
            this.Name = "FrmModifierEmploye";
            this.Text = "Modifier un Employé";
            this.Load += new System.EventHandler(this.FrmModifierEmploye_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
    }
}
