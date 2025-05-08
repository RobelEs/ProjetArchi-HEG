
using System;
using System.Collections.Generic; // Pour List<>
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // Pour Task et async/await
using System.Windows.Forms;
using System.Net.Http;         // Pour HttpClient
using System.Net.Http.Headers; // Pour AuthenticationHeaderValue
using Newtonsoft.Json;       // Pour JsonConvert

namespace ProjetArchi
{
    public partial class FmrGestionChantier: Form
    {
        private List<ChantierModel> _listeChantiers;

        // URL de base de ton API Laravel (vérifie qu'elle se termine par '/')
        private const string ApiBaseUrl = "http://127.0.0.1:8000/";
        public FmrGestionChantier()
        {
            InitializeComponent();
        }

        private async void FmrGestionChantier_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();

            // 2. Charge les données depuis l'API de manière asynchrone
            await ChargerDonneesChantiersAsync();
        }

        private void ConfigureDataGridView()
        {
            // Référence directe au contrôle DataGridView placé dans le designer
            var dgv = dgvChantier;

            // Propriétés de base pour une meilleure présentation
            dgv.AllowUserToAddRows = false; // Empêche l'ajout manuel de lignes
            dgv.ReadOnly = true;           // Empêche la modification directe dans les cellules
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Sélectionne toute la ligne
            dgv.MultiSelect = false;       // Empêche la sélection de plusieurs lignes
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; // Ajuste colonnes au contenu
            dgv.RowHeadersVisible = false; // Cache la colonne d'en-tête de ligne (souvent inutile)
            dgv.BackgroundColor = SystemColors.Window; // Fond standard

            // Efface d'éventuelles colonnes définies dans le designer (pour être sûr)
            dgv.Columns.Clear();

            // Crée et ajoute les colonnes dans l'ordre souhaité
            // Le 'Name' est important, il correspondra souvent aux clés JSON/modèle
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "id",
                HeaderText = "ID",
                ValueType = typeof(int),
                Width = 50
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "name",
                HeaderText = "Nom Chantier",
                ValueType = typeof(string),
                MinimumWidth = 150
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "address",
                HeaderText = "Adresse",
                ValueType = typeof(string),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill // Prend l'espace restant
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "start_date",
                HeaderText = "Début",
                ValueType = typeof(string),
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "end_date",
                HeaderText = "Fin",
                ValueType = typeof(string),
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "client_id",
                HeaderText = "ID Client",
                ValueType = typeof(int),
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            });
        }

        // --- Charge les données depuis l'API et peuple le DataGridView ---
        private async Task ChargerDonneesChantiersAsync()
        {
            var dgv = dgvChantier; // Référence au contrôle
            dgv.Rows.Clear();     // Vide les données précédentes
            _listeChantiers = null; // Réinitialise la liste interne

            // Indique visuellement que quelque chose se passe
            this.Cursor = Cursors.WaitCursor;
            dgv.Enabled = false; // Empêche l'interaction pendant le chargement

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Configuration de la requête HTTP
                    client.BaseAddress = new Uri(ApiBaseUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // Ajout du token d'authentification (essentiel!)
                    if (string.IsNullOrEmpty(SessionManager.AuthToken))
                    {
                        MessageBox.Show("Token d'authentification non trouvé.", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return; // Arrête le processus
                    }
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.AuthToken);

                    // Appel à l'API (GET api/chantiers)
                    HttpResponseMessage response = await client.GetAsync("api/chantiers");

                    // Traitement de la réponse
                    if (response.IsSuccessStatusCode) // Requête réussie (code 2xx)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();

                        // Tentative de désérialisation (gère les 2 formats courants de Laravel)
                        try
                        {   // Essai 1: Tableau JSON direct [...]
                            _listeChantiers = JsonConvert.DeserializeObject<List<ChantierModel>>(jsonString);
                        }
                        catch (JsonSerializationException) // Si ce n'est pas un tableau direct
                        {
                            try
                            {   // Essai 2: Enveloppé dans {"data": [...]}
                                var apiResponse = JsonConvert.DeserializeObject<ApiResponseWrapper<List<ChantierModel>>>(jsonString);
                                _listeChantiers = apiResponse?.Data; // Extrait la liste
                            }
                            catch (Exception exInner)
                            {
                                // Erreur si même le format enveloppé ne fonctionne pas
                                MessageBox.Show($"Impossible de lire les données JSON reçues: {exInner.Message}", "Erreur Format JSON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Remplissage du DataGridView si la désérialisation a réussi
                        if (_listeChantiers != null)
                        {
                            dgv.SuspendLayout(); // Suspend le rafraîchissement pour performance
                            dgv.Rows.Clear();   // Sécurité pour vider à nouveau

                            foreach (var chantier in _listeChantiers)
                            {
                                // Ajoute une ligne avec les données dans l'ordre des colonnes créées
                                dgv.Rows.Add(
                                    chantier.Id,
                                    chantier.Name,
                                    chantier.Address,
                                    chantier.StartDate, // Affiché tel quel
                                    chantier.EndDate,   // Affiché tel quel
                                    chantier.ClientId
                                );
                            }
                            dgv.ResumeLayout(); // Réactive le rafraîchissement
                        }
                        // Pas besoin de 'else' ici, si _listeChantiers est null, une erreur a déjà été affichée.
                    }
                    else // La requête HTTP a échoué (code 4xx, 5xx)
                    {
                        string errorContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Erreur de l'API ({response.StatusCode}):\n{errorContent}", "Erreur API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (HttpRequestException httpEx) // Erreurs réseau (connexion impossible, DNS...)
                {
                    MessageBox.Show($"Erreur réseau : Impossible de contacter l'API.\nVérifiez l'URL ({ApiBaseUrl}) et la connexion.\n{httpEx.Message}", "Erreur de Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (JsonException jsonEx) // Erreurs pendant la désérialisation (si non attrapées avant)
                {
                    MessageBox.Show($"Erreur lors de la lecture des données JSON: {jsonEx.Message}", "Erreur Données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) // Captures d'autres erreurs inattendues
                {
                    MessageBox.Show($"Une erreur inattendue est survenue: {ex.Message}", "Erreur Inattendue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally // Ce bloc s'exécute toujours (après try ou catch)
                {
                    // Rétablit le curseur et réactive le DataGridView
                    this.Cursor = Cursors.Default;
                    dgv.Enabled = true;
                }
            }
        }

        private void dgvChantier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int chantierId = (int)dgvChantier.Rows[e.RowIndex].Cells["id"].Value;
                var chantier = _listeChantiers.FirstOrDefault(c => c.Id == chantierId);
                // Ouvre le formulaire de modification
                if (chantier != null)
                {
                    using (FmrModifierChantier modifierChantierForm = new FmrModifierChantier(chantier))
                    {
                        modifierChantierForm.ShowDialog();
                        // Recharge les données après la fermeture du formulaire
                        // ChargerDonneesChantiersAsync();
                    }
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (FmrModifierChantier form = new FmrModifierChantier(new ChantierModel(), true))
            {
                form.ShowDialog();
               
            }
        }
    }
}
