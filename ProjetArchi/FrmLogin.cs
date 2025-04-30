using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;

namespace ProjetArchi
{
    public partial class FrmLogin : Form
    {
        // --- MODIFICATION : Instance HttpClient statique et readonly ---
        // Créer une seule instance HttpClient pour être réutilisée.
        // 'static' signifie qu'elle appartient à la classe FrmLogin, pas à une instance spécifique.
        // 'readonly' signifie qu'elle ne peut être assignée qu'ici ou dans un constructeur statique.
        private static readonly HttpClient client = new HttpClient();

        public FrmLogin()
        {
            InitializeComponent();

            // --- MODIFICATION : Configurer le client HttpClient une seule fois ---
            // Déplacer la configuration de base ici (ou dans un constructeur statique si plus complexe).
            // TODO: Pour une meilleure pratique, cette URL devrait provenir d'un fichier de configuration (App.config).
            // client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ApiBaseUrl"] ?? "http://127.0.0.1:8000/api/");
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            // --- FIN MODIFICATION ---
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Généralement inutile sauf si label1 a une fonction spécifique.
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Veuillez entrer votre adresse e-mail.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus(); // Met le focus sur le champ email
                return; // Arrête l'exécution de la méthode
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Veuillez entrer votre mot de passe.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus(); // Met le focus sur le champ mot de passe
                return; // Arrête l'exécution de la méthode
            }

            try
            {
                btnLogin.Enabled = false;
                Cursor = Cursors.WaitCursor; // Changer le curseur

                string token = await LoginAsync(email, password);
                SessionManager.AuthToken = token;

                MessageBox.Show("Connexion réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cacher le formulaire de login au lieu de le fermer 
                // this.Hide(); // Ou this.Close() 

                using (Form1 form1 = new Form1())
                {
                    // Vous pourriez vouloir passer le token ou d'autres infos à Form1 via son constructeur
                    // Form1 form1 = new Form1(token);
                    form1.ShowDialog(); // Bloque jusqu'à ce que form1 soit fermé
                }

                // Si vous avez utilisé Hide(), vous pouvez fermer le login ici après que Form1 soit fermé
                // this.Close();

            }
            catch (HttpRequestException httpEx) // Capturer l'exception spécifique lancée par LoginAsync
            {
                // L'exception contient déjà un message formaté par LoginAsync
                MessageBox.Show("Erreur de connexion : " + httpEx.Message, "Erreur Réseau", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) // Capturer toute autre exception imprévue
            {
                // Erreur plus générique
                MessageBox.Show("Une erreur inattendue est survenue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally // Ce bloc s'exécute toujours, que la connexion réussisse ou échoue
            {
                // Réactiver le bouton et restaurer le curseur
                btnLogin.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        // Méthode pour effectuer la requête de connexion à l'API
        private async Task<string> LoginAsync(string email, string password)
        {
            // --- MODIFICATION : Utiliser le client statique ---
            // Supprimer : using (HttpClient client = new HttpClient())
            // Supprimer : client.BaseAddress = ...
            // Supprimer : client.DefaultRequestHeaders.Accept.Clear(); ...
            // Nous utilisons maintenant l'instance 'client' statique configurée dans le constructeur.
            // --- FIN MODIFICATION ---

            var data = new
            {
                email = email,
                password = password
            };

            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Utilise l'instance 'client' statique
            HttpResponseMessage response = await client.PostAsync("login", content);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                dynamic jsonResult = JsonConvert.DeserializeObject(result);

                // Vérifier si la propriété token existe avant d'y accéder (plus sûr)
                if (jsonResult?.token == null)
                {
                    throw new HttpRequestException("La réponse du serveur ne contient pas de token valide.");
                }
                string token = jsonResult.token;
                return token;
            }
            else
            {
                // --- La gestion d'erreur existante est déjà très bonne ---
                string errorContent = await response.Content.ReadAsStringAsync();
                string errorMessage = $"Échec de la requête : {(int)response.StatusCode} ({response.ReasonPhrase}).";

                try
                {
                    dynamic errorJson = JsonConvert.DeserializeObject(errorContent);
                    // Utilise l'opérateur null-coalescing pour trouver le message d'erreur
                    string serverMessage = errorJson?.error ?? errorJson?.message ?? errorContent;
                    errorMessage += $"\nMessage Serveur: {serverMessage}";
                }
                catch (JsonReaderException) // Si la réponse d'erreur n'est pas du JSON valide
                {
                    // Limite la taille pour éviter d'afficher une énorme page HTML d'erreur
                    errorMessage += $"\nRéponse brute: {errorContent.Substring(0, Math.Min(errorContent.Length, 500))}";
                }
                catch (Exception ex) // Autre erreur lors de la lecture/désérialisation du message d'erreur
                {
                    errorMessage += $"\nImpossible de lire le message d'erreur détaillé: {ex.Message}";
                    errorMessage += $"\nRéponse brute: {errorContent.Substring(0, Math.Min(errorContent.Length, 500))}";
                }
                throw new HttpRequestException(errorMessage); // Lance l'exception qui sera capturée dans btnLogin_Click
            
            }
        }

    }
}
