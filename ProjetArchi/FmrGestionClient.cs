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
    public partial class FmrGestionClient: Form
    {
        public FmrGestionClient()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (FmrModifierClient formModifierClient = new FmrModifierClient(true))
            {
                formModifierClient.ShowDialog();
            }
        }

        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (FmrModifierClient modifierClientForm = new FmrModifierClient())
                {
                    modifierClientForm.ShowDialog();
                }
            }
        }

        private void FmrGestionClient_Load(object sender, EventArgs e)
        {
            dgvClient.Rows.Add("Ro", "Afu", "afu@gmail.com");
            dgvClient.Rows.Add("Noe", "Silva", "silva@gmail.com");

        }
    }
}
