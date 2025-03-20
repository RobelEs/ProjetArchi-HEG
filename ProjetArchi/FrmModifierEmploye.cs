using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetArchi
{
    public partial class FrmModifierEmploye : Form
    {
        public FrmModifierEmploye()
        {
            InitializeComponent();
        }

        private void FrmModifierEmploye_Load(object sender, EventArgs e)
        {
            // Ici, tu peux charger des données d'un employé dans les TextBox si besoin
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string role = txtRole.Text;

            // Vérification que les champs ne sont pas vides
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Tous les champs doivent être remplis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Logique pour enregistrer les modifications
            MessageBox.Show($"Modifications enregistrées:\nNom: {nom}\nPrénom: {prenom}\nRôle: {role}",
                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblPrenom_Click(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
