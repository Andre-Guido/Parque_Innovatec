using System;
using System.Windows.Forms;

namespace Parque_Innovatec.Formularios
{
    public partial class FrmArbol : Form
    {
        
        public FrmArbol()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para agregar la raíz del árbol.
        /// </summary>
        private void agregarRaiz()
        {
            if (tvArbol.Nodes.Count <= 0)
            {
                tvArbol.Nodes.Add(tbRaiz.Text);
            }
            else
            {
                MessageBox.Show("Solo se permite una raíz.");
            }
            tvArbol.ExpandAll();
            tbRaiz.Clear();
            tbRaiz.Focus();
        }

        /// <summary>
        /// Método para agregar un hijo al árbol.
        /// </summary>
        private void agregarHijo()
        {
            if (tvArbol.SelectedNode != null)
            {
                tvArbol.SelectedNode.Nodes.Add(tbNodoHijo.Text);
            }
            else
            {
                MessageBox.Show("Seleccione un nodo padre.");
            }
            tvArbol.ExpandAll();
            tbNodoHijo.Clear();
            tbNodoHijo.Focus();
        }

        private void btnAgregarRaiz_Click(object sender, EventArgs e)
        {
            agregarRaiz();
        }

        private void btnAgregarRama_Click(object sender, EventArgs e)
        {
            agregarHijo();
        }
    }
}
