using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasoDeEstudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarArbol();
        }


        private void InicializarArbol()
        {
            TreeNode nodoRaiz = new TreeNode("Innovatec Direccion general");
            treeViewOrg.Nodes.Add(nodoRaiz);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContarNodos_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text))
            {
                MessageBox.Show("Por favor, ingresa un nombre");
                return;
            }
            TreeNode nodoSeleccionado = treeViewOrg.SelectedNode;

            if(nodoSeleccionado == null)
            {
                if (treeViewOrg.Nodes.Count > 0)
                {
                    nodoSeleccionado = treeViewOrg.Nodes[0];
                }
                else
                {
                    MessageBox.Show("No hay un nodo raiz. Anadiendo como raiz");
                    treeViewOrg.Nodes.Add(txtNombreEmpleado.Text);
                    txtNombreEmpleado.Clear();
                    return;
                }
            }
            nodoSeleccionado.Nodes.Add(txtNombreEmpleado.Text);
            nodoSeleccionado.Expand();
            txtNombreEmpleado.Clear();
        }
    }
}
