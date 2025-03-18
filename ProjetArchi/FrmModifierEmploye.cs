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
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string role = textBoxRole.Text;

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
    }
}
