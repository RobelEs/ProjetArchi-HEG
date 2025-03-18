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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gestionDesEmployésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FmrGestionEmploye gestionEmployeForm = new FmrGestionEmploye())
            {
                gestionEmployeForm.ShowDialog(); // Affiche la fenêtre en mode bloquant
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
