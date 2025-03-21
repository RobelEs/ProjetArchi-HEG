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
                using (FrmModifierEmploye formModifierEmploye = new FrmModifierEmploye(true))
                {
                formModifierEmploye.ShowDialog();
                }
        }

        private void FmrGestionEmploye_Load(object sender, EventArgs e)
        {
            dgvEmploye.Rows.Add("Alice", "Dupont", "Développeur");
            dgvEmploye.Rows.Add("Bob", "Martin", "Manager");
            dgvEmploye.Rows.Add("Charlie", "Durand", "Technicien");
            dgvEmploye.Rows.Add("Charlie", "Delta", "Technicien");


            


            dgvEmploye.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmploye.BorderStyle = BorderStyle.Fixed3D;
            dgvEmploye.BackgroundColor = Color.White;
            dgvEmploye.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dgvEmploye.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvEmploye.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvEmploye.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Personnalisation du bouton Ajouter

            //btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.FlatAppearance.BorderSize = 2;  // Ajouter une bordure autour du bouton
            btnAjouter.FlatAppearance.BorderColor = Color.Black;  // Bordure noire pour contraster avec le fond
            //btnAjouter.Padding = new Padding(10);
            //btnAjouter.Cursor = Cursors.Hand;  // Changer le curseur pour donner un effet interactif




        }
    }
}
