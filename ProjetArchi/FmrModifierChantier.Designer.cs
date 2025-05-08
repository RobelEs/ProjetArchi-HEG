namespace ProjetArchi
{
    partial class FmrModifierChantier
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtDateDebut = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtDateFin = new System.Windows.Forms.TextBox();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.clientId = new System.Windows.Forms.TextBox();
            this.client = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAjouter.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(192, 281);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(200, 30);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(192, 353);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(200, 30);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnModifier.Font = new System.Drawing.Font("Arial", 10F);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(192, 317);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(200, 30);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "&Modifer";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtDateDebut
            // 
            this.txtDateDebut.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDateDebut.Location = new System.Drawing.Point(192, 142);
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.Size = new System.Drawing.Size(200, 27);
            this.txtDateDebut.TabIndex = 5;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAdresse.Location = new System.Drawing.Point(192, 87);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(200, 27);
            this.txtAdresse.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNom.Location = new System.Drawing.Point(192, 37);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 27);
            this.txtNom.TabIndex = 1;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Arial", 10F);
            this.lblDateDebut.Location = new System.Drawing.Point(58, 142);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(91, 19);
            this.lblDateDebut.TabIndex = 4;
            this.lblDateDebut.Text = "DateDebut:";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Arial", 10F);
            this.lblAdresse.Location = new System.Drawing.Point(58, 87);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(74, 19);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "Adresse:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNom.Location = new System.Drawing.Point(58, 37);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 19);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "&Nom:";
            // 
            // txtDateFin
            // 
            this.txtDateFin.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDateFin.Location = new System.Drawing.Point(192, 191);
            this.txtDateFin.Name = "txtDateFin";
            this.txtDateFin.Size = new System.Drawing.Size(200, 27);
            this.txtDateFin.TabIndex = 7;
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Arial", 10F);
            this.lblDateFin.Location = new System.Drawing.Point(58, 195);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(91, 19);
            this.lblDateFin.TabIndex = 6;
            this.lblDateFin.Text = "DateDebut:";
            // 
            // clientId
            // 
            this.clientId.Font = new System.Drawing.Font("Arial", 10F);
            this.clientId.Location = new System.Drawing.Point(192, 237);
            this.clientId.Name = "clientId";
            this.clientId.Size = new System.Drawing.Size(200, 27);
            this.clientId.TabIndex = 11;
            // 
            // client
            // 
            this.client.AutoSize = true;
            this.client.Font = new System.Drawing.Font("Arial", 10F);
            this.client.Location = new System.Drawing.Point(58, 245);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(69, 19);
            this.client.TabIndex = 12;
            this.client.Text = "client_id";
            this.client.Click += new System.EventHandler(this.label1_Click);
            // 
            // FmrModifierChantier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(504, 401);
            this.Controls.Add(this.client);
            this.Controls.Add(this.clientId);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.txtDateFin);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtDateDebut);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblNom);
            this.Name = "FmrModifierChantier";
            this.Text = "FmrModifierChantier";
            this.Load += new System.EventHandler(this.FmrModifierChantier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtDateDebut;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtDateFin;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.TextBox clientId;
        private System.Windows.Forms.Label client;
    }
}