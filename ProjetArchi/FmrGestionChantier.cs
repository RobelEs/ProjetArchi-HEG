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
    public partial class FmrGestionChantier: Form
    {
        public FmrGestionChantier()
        {
            InitializeComponent();
        }

        private void FmrGestionChantier_Load(object sender, EventArgs e)
        {
            dgvChantier.Rows.Add("Balexe", "Chemin de Balexert 17", "12/05/2021","30/03/2023");
            dgvChantier.Rows.Add("HEG", "Chemin de l'HEG", "12/05/2022","30/03/2023");
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (FmrModifierChantier formModifierChantier = new FmrModifierChantier(true))
            {
                formModifierChantier.ShowDialog();
            }
        }

        private void dgvChantier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

            {
                using (FmrModifierChantier modifierChantierForm = new FmrModifierChantier())
                {
                    modifierChantierForm.ShowDialog();
                }
            }
        }
    }
}
