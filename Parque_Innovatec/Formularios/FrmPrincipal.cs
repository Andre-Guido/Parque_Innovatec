using Parque_Innovatec.Formularios;
using System;
using System.Windows.Forms;

namespace Parque_Innovatec
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void jerarquíaAdministrativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmArbol().Show();
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmGrafo().Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
