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
    public partial class FmrModifierClient: Form
    {
        public FmrModifierClient(Boolean creat = false)
        {
            InitializeComponent();
            btnSupprimer.Visible = !creat;
            btnValider.Visible = !creat;
            btnAjouter.Visible = creat;
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

            // Logique pour enregistrer les modifications
            MessageBox.Show($"Modifications enregistrées:\nNom: {nom}\nPrénom: {prenom}\nRôle: {email}",
                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FmrModifierClient_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
