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
    public partial class FmrGestionEmploye : Form
    {
        public FmrGestionEmploye()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifie si on clique sur une cellule valide (pour éviter des erreurs avec les en-têtes)
            if (e.RowIndex >= 0)
            {
                using (FrmModifierEmploye modifierEmployeForm = new FrmModifierEmploye())
                {
                    modifierEmployeForm.ShowDialog();
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Ouverture du formulaire pour ajouter un employé
            using (FormAjouterEmploye formAjouterEmploye = new FormAjouterEmploye())
            {
                formAjouterEmploye.ShowDialog();
            }
        }

        private void FmrGestionEmploye_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Alice", "Dupont", "Développeur");
            dataGridView1.Rows.Add("Bob", "Martin", "Manager");
            dataGridView1.Rows.Add("Charlie", "Durand", "Technicien");
            dataGridView1.Rows.Add("Charlie", "Delta", "Technicien");


            


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Personnalisation du bouton Ajouter

            //btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.FlatAppearance.BorderSize = 2;  // Ajouter une bordure autour du bouton
            btnAjouter.FlatAppearance.BorderColor = Color.Black;  // Bordure noire pour contraster avec le fond
            //btnAjouter.Padding = new Padding(10);
            //btnAjouter.Cursor = Cursors.Hand;  // Changer le curseur pour donner un effet interactif




        }
    }
}
