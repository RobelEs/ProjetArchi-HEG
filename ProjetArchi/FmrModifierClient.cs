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
    public partial class FmrModifierClient : Form
    {
        public FmrModifierClient(bool isCreate = false)
        {
            InitializeComponent();
            btnSupprimer.Visible = !isCreate;
            btnValider.Visible = !isCreate;
            btnAjouter.Visible = isCreate;
        }

        // Méthode pour remplir les champs avec les données d'un client existant
        public void SetClientData(string nom, string prenom, string email)
        {
            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            txtEmail.Text = email;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string email = txtEmail.Text;

            // Vérification que les champs ne sont pas vides
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Tous les champs doivent être remplis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Affichage du message de confirmation
            MessageBox.Show($"Modifications enregistrées :\nNom : {nom}\nPrénom : {prenom}\nEmail : {email}",
                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Fermer la fenêtre après validation
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce client ?",
                                                   "Confirmation de suppression",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Logique de suppression du client ici
                MessageBox.Show("Client supprimé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string email = txtEmail.Text;

            // Vérification que les champs ne sont pas vides
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Tous les champs doivent être remplis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Logique pour enregistrer un nouveau client
            MessageBox.Show($"Client ajouté :\nNom: {nom}\nPrénom: {prenom}\nEmail: {email}",
                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Effacer les champs après l'ajout
            txtNom.Clear();
            txtPrenom.Clear();
            txtEmail.Clear();
        }
        private void FmrModifierClient_Load(object sender, EventArgs e)
        {

        }
    }
}
