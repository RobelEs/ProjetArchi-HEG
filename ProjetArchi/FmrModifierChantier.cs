using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetArchi
{
    public partial class FmrModifierChantier : Form
    {
        private ChantierModel _chantier;

        public FmrModifierChantier(ChantierModel chantier, Boolean creat = false)
        {

            InitializeComponent();
            // Initialisation des champs
            _chantier = chantier;
            btnSupprimer.Visible = !creat;
            btnModifier.Visible = !creat;
            btnAjouter.Visible = creat;
        }

        private void FmrModifierChantier_Load(object sender, EventArgs e)
        {
            txtNom.Text = _chantier.Name;
            txtAdresse.Text = _chantier.Address;
            txtDateDebut.Text = _chantier.StartDate;
            txtDateFin.Text = _chantier.EndDate;
            clientId.Text = _chantier.ClientId.ToString();

        }

        private async void btnSupprimer_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Voulez-vous vraiment supprimer ce chantier ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("http://127.0.0.1:8000/");
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.AuthToken);

                        HttpResponseMessage response = await client.DeleteAsync($"api/chantiers/{_chantier.Id}");

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Chantier supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            string responseContent = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Erreur API : {response.StatusCode}\n{responseContent}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur de connexion : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnValider_Click(object sender, EventArgs e)
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
            var chantierData = new
            {
                name = nom,
                address = adresse,
                start_date = parsedDateDebut.ToString("yyyy-MM-dd"),
                end_date = parsedDateFin.ToString("yyyy-MM-dd")
            };
            // Appel de l'API pour mettre à jour le chantier
            try
            {
                using (HttpClient client = new HttpClient()) 
                {
                    client.BaseAddress = new Uri("http://127.0.0.1:8000/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.AuthToken);
                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(chantierData);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PutAsync($"api/chantiers/{_chantier.Id}/", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Chantier mis à jour avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Erreur API : {response.StatusCode}\n{responseContent}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Message de confirmation
                MessageBox.Show($"Modifications enregistrées :\nNom: {nom}\nAdresse: {adresse}\nDate de début: {parsedDateDebut.ToShortDateString()}\nDate de fin: {parsedDateFin.ToShortDateString()}",
                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Fermer la fenêtre après validation
            this.Close();

        }
        }

        private async void btnAjouter_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string adresse = txtAdresse.Text;
            string dateDebut = txtDateDebut.Text;
            string dateFin = txtDateFin.Text;
            int client_id = Convert.ToInt32(clientId.Text);


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

            var chantierData = new
            {
                name = nom,
                address = adresse,
                start_date = parsedDateDebut.ToString("yyyy-MM-dd"),
                end_date = parsedDateFin.ToString("yyyy-MM-dd"),
                client_id = 2
            };

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://127.0.0.1:8000/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.AuthToken);

                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(chantierData);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync("api/chantiers/", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Chantier ajouté avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Erreur API : {response.StatusCode}\n{responseContent}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}