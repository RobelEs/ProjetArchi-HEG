﻿namespace ProjetArchi
{
    partial class FormAjouterEmploye
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.grpInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(200, 61);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 22);
            this.txtNom.TabIndex = 1;
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.btnValider);
            this.grpInformation.Controls.Add(this.lblRole);
            this.grpInformation.Controls.Add(this.lblPrenom);
            this.grpInformation.Controls.Add(this.lblNom);
            this.grpInformation.Controls.Add(this.txtRole);
            this.grpInformation.Controls.Add(this.txtPrenom);
            this.grpInformation.Controls.Add(this.txtNom);
            this.grpInformation.Location = new System.Drawing.Point(12, 12);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(427, 303);
            this.grpInformation.TabIndex = 1;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Information";
            this.grpInformation.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(325, 245);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(23, 179);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(36, 16);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Rôle";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(23, 115);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(54, 16);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom";
            this.lblPrenom.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(23, 66);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(36, 16);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            this.lblNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(200, 176);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(200, 22);
            this.txtRole.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(200, 115);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(200, 22);
            this.txtPrenom.TabIndex = 3;
            // 
            // FormAjouterEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(540, 366);
            this.Controls.Add(this.grpInformation);
            this.MinimumSize = new System.Drawing.Size(558, 413);
            this.Name = "FormAjouterEmploye";
            this.Text = "FormAjouterEmploye";
            this.Load += new System.EventHandler(this.FormAjouterEmploye_Load);
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Button btnValider;
    }
}