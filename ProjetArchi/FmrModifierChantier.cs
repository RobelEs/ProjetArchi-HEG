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
    public partial class FmrModifierChantier: Form
    {
        public FmrModifierChantier(Boolean creat = false)
        {
            InitializeComponent();
            btnSupprimer.Visible = !creat;
            btnModifier.Visible = !creat;
            btnAjouter.Visible = creat;
        }

        private void FmrModifierChantier_Load(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string adresse = txtAdresse.Text;
            string dateDebut = txtDateDebut.Text;
            string dateFin = txtDateFin.Text;

            // Vérification que les champs ne sont pas vides
            if (string.IsNullOrWhiteSpace(nom) ||
                string.IsNullOrWhiteSpace(adresse) ||
                string.IsNullOrWhiteSpace(dateDebut) ||
                string.IsNullOrWhiteSpace(dateFin))
            {
                MessageBox.Show("Tous les champs doivent être remplis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérification du format de la date
            DateTime parsedDateDebut, parsedDateFin;
            if (!DateTime.TryParse(dateDebut, out parsedDateDebut) || !DateTime.TryParse(dateFin, out parsedDateFin))
            {
                MessageBox.Show("Les dates doivent être au format valide (jj/mm/aaaa)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérification que la date de début est avant la date de fin
            if (parsedDateDebut > parsedDateFin)
            {
                MessageBox.Show("La date de début doit être antérieure à la date de fin", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Message de confirmation
            MessageBox.Show($"Modifications enregistrées :\nNom: {nom}\nAdresse: {adresse}\nDate de début: {parsedDateDebut.ToShortDateString()}\nDate de fin: {parsedDateFin.ToShortDateString()}",
                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Fermer la fenêtre après validation
            this.Close();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string adresse = txtAdresse.Text;
            string dateDebut = txtDateDebut.Text;
            string dateFin = txtDateFin.Text;

            // Vérification que les champs ne sont pas vides
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(adresse) ||
                string.IsNullOrWhiteSpace(dateDebut) || string.IsNullOrWhiteSpace(dateFin))
            {
                MessageBox.Show("Tous les champs doivent être remplis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérification du format des dates
            if (!DateTime.TryParse(dateDebut, out DateTime parsedDateDebut) ||
                !DateTime.TryParse(dateFin, out DateTime parsedDateFin))
            {
                MessageBox.Show("Les dates doivent être au format valide (jj/mm/aaaa)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérification de l'ordre des dates
            if (parsedDateDebut > parsedDateFin)
            {
                MessageBox.Show("La date de début doit être avant la date de fin", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmation de l'ajout
            MessageBox.Show($"Chantier ajouté :\nNom : {nom}\nAdresse : {adresse}\nDébut : {parsedDateDebut:dd/MM/yyyy}\nFin : {parsedDateFin:dd/MM/yyyy}",
                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNom.Clear();
            txtAdresse.Clear();
            txtDateDebut.Clear();
            txtDateFin.Clear();
        }
    }
}
