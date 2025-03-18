namespace ProjetArchi
{
    partial class FrmModifierEmploye
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxRole;
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Arial", 10F);
            this.labelNom.Location = new System.Drawing.Point(50, 50);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(47, 19);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "&Nom:";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Arial", 10F);
            this.labelPrenom.Location = new System.Drawing.Point(50, 100);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(71, 19);
            this.labelPrenom.TabIndex = 2;
            this.labelPrenom.Text = "Prénom:";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Arial", 10F);
            this.labelRole.Location = new System.Drawing.Point(50, 150);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(46, 19);
            this.labelRole.TabIndex = 4;
            this.labelRole.Text = "Rôle:";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxNom.Location = new System.Drawing.Point(150, 46);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(200, 27);
            this.textBoxNom.TabIndex = 1;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxPrenom.Location = new System.Drawing.Point(150, 96);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(200, 27);
            this.textBoxPrenom.TabIndex = 3;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxRole.Location = new System.Drawing.Point(150, 146);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(200, 27);
            this.textBoxRole.TabIndex = 5;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnValider.Font = new System.Drawing.Font("Arial", 10F);
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(150, 200);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(200, 30);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider les modifications";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // FrmModifierEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 308);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.MinimumSize = new System.Drawing.Size(385, 285);
            this.Name = "FrmModifierEmploye";
            this.Text = "Modifier un Employé";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
