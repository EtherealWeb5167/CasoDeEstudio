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


        private List<string> edificios = new List<string>();

        private const int MAX_EDIFICIOS = 20;
        private int[,] matrizAdyacencia = new int[MAX_EDIFICIOS, MAX_EDIFICIOS];

        private const int INFINITO = 99999;



        public Form1()
        {
            InitializeComponent();
            InicializarArbol();

            for (int i = 0; i < MAX_EDIFICIOS; i++)
            {
                for (int j = 0; j < MAX_EDIFICIOS; j++)
                {
                    if (i == j)
                        matrizAdyacencia[i, j] = 0; 
                    else
                        matrizAdyacencia[i, j] = INFINITO; 
                }
            }
        }
        


        private void InicializarArbol()
        {
            TreeNode nodoRaiz = new TreeNode("Innovatec (Direccion General)");
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
            int conteo = treeViewOrg.GetNodeCount(true);
            lblResultadoArbol.Text = $"Total de nodos (empleados/áreas): {conteo}";
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre.");
                return;
            }

            TreeNode nodoSeleccionado = treeViewOrg.SelectedNode;

            if (nodoSeleccionado == null)
            {
                if (treeViewOrg.Nodes.Count > 0)
                {
                    nodoSeleccionado = treeViewOrg.Nodes[0];
                }
                else
                {
                    MessageBox.Show("No hay un nodo raiz. Anadiendo como raiz.");
                    treeViewOrg.Nodes.Add(txtNombreEmpleado.Text);
                    txtNombreEmpleado.Clear();
                    return;
                }
            }

            nodoSeleccionado.Nodes.Add(txtNombreEmpleado.Text);
            nodoSeleccionado.Expand();
            txtNombreEmpleado.Clear();
        }

        private void btnProfundidad_Click(object sender, EventArgs e)
        {
            if (treeViewOrg.Nodes.Count == 0)
            {
                lblResultadoArbol.Text = "arbol esta vacio.";
                return;
            }
            TreeNode raiz = treeViewOrg.Nodes[0];
            int profundidad = ObtenerProfundidad(raiz);
            lblResultadoArbol.Text = $"Niveles del arbol (profundidad): {profundidad}";
        }
        

        private int ObtenerProfundidad(TreeNode nodo)
        {
            if (nodo == null)
                return 0;

            int maxProfundidadHijos = 0;
            foreach (TreeNode hijo in nodo.Nodes)
            {
                int profundidadHijo = ObtenerProfundidad(hijo);
                if (profundidadHijo > maxProfundidadHijos)
                {
                    maxProfundidadHijos = profundidadHijo;
                }
            }
            return 1 + maxProfundidadHijos;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text))
            {
                MessageBox.Show("Ingrese un nombre para buscar.");
                return;
            }

            string nombreABuscar = txtNombreEmpleado.Text;
            TreeNode nodoEncontrado = BuscarNodo(treeViewOrg.Nodes, nombreABuscar);

            if (nodoEncontrado != null)
            {
                treeViewOrg.SelectedNode = nodoEncontrado;
                treeViewOrg.Focus();
                lblResultadoArbol.Text = $"'{nombreABuscar}' encontrado.";
            }
            else
            {
                lblResultadoArbol.Text = $"'{nombreABuscar}' NO encontrado.";
            }
        }

        private TreeNode BuscarNodo(TreeNodeCollection nodos, string texto)
        {
            foreach (TreeNode nodo in nodos)
            {
                if (nodo.Text.Equals(texto, StringComparison.OrdinalIgnoreCase))
                {
                    return nodo;
                }

                TreeNode nodoHijo = BuscarNodo(nodo.Nodes, texto);
                if (nodoHijo != null)
                {
                    return nodoHijo;
                }
            }
            return null;
        }

        private void btnAgregarEdificio_Click(object sender, EventArgs e)
        {
            string nombreEdificio = txtEdificio.Text;

            if (string.IsNullOrWhiteSpace(nombreEdificio) || edificios.Contains(nombreEdificio))
            {
                MessageBox.Show("Nombre de edificio invalido o ya existente.");
                return;
            }
            if (edificios.Count >= MAX_EDIFICIOS)
            {
                MessageBox.Show("Limite de edificios alcanzado.");
                return;
            }

            edificios.Add(nombreEdificio);
            txtEdificio.Clear();
            ActualizarComboBoxGrafos();
            ActualizarListaResultadosGrafo();
            MessageBox.Show($"Edificio '{nombreEdificio}' agregado.");
        }

        private void ActualizarComboBoxGrafos()
        {
            cmbOrigen.Items.Clear();
            cmbDestino.Items.Clear();
            foreach (string edificio in edificios)
            {
                cmbOrigen.Items.Add(edificio);
                cmbDestino.Items.Add(edificio);
            }
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            if (cmbOrigen.SelectedIndex == -1 || cmbDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un origen y un destino.");
                return;
            }
            if (!int.TryParse(txtDistancia.Text, out int distancia) || distancia <= 0)
            {
                MessageBox.Show("Ingrese una distancia (peso) valida (numero > 0).");
                return;
            }
            if (cmbOrigen.SelectedIndex == cmbDestino.SelectedIndex)
            {
                MessageBox.Show("No se puede crear una ruta a si mismo.");
                return;
            }

            int idxOrigen = cmbOrigen.SelectedIndex;
            int idxDestino = cmbDestino.SelectedIndex;

            matrizAdyacencia[idxOrigen, idxDestino] = distancia;
            matrizAdyacencia[idxDestino, idxOrigen] = distancia;

            ActualizarListaResultadosGrafo();
            MessageBox.Show("Ruta agregada.");
        }

        private void ActualizarListaResultadosGrafo()
        {
            lstResultadoGrafo.Items.Clear();
            lstResultadoGrafo.Items.Add("--- Edificios Registrados ---");
            for (int i = 0; i < edificios.Count; i++)
            {
                lstResultadoGrafo.Items.Add($"[{i}] {edificios[i]}");
            }

            lstResultadoGrafo.Items.Add(""); 
            lstResultadoGrafo.Items.Add("--- Conexiones (Matriz) ---");
            for (int i = 0; i < edificios.Count; i++)
            {
                for (int j = i + 1; j < edificios.Count; j++)
                {
                    if (matrizAdyacencia[i, j] != INFINITO)
                    {
                        lstResultadoGrafo.Items.Add(
                            $"{edificios[i]} <-> {edificios[j]} (Dist: {matrizAdyacencia[i, j]})"
                        );
                    }
                }
            }
        }

        private void btnRutaMasCorta_Click(object sender, EventArgs e)
        {
            if (cmbOrigen.SelectedIndex == -1 || cmbDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un origen y un destino.");
                return;
            }

            int idxOrigen = cmbOrigen.SelectedIndex;
            int idxDestino = cmbDestino.SelectedIndex;

            Dijkstra(idxOrigen, idxDestino);
        }

        private void Dijkstra(int inicio, int fin)
        {
            int n = edificios.Count;
            int[] distancias = new int[n];
            bool[] visitado = new bool[n];
            int[] previo = new int[n];

            for (int i = 0; i < n; i++)
            {
                distancias[i] = INFINITO;
                visitado[i] = false;
                previo[i] = -1;
            }
            distancias[inicio] = 0;

            for (int count = 0; count < n - 1; count++)
            {
                int u = MinimaDistancia(distancias, visitado, n);
                if (u == -1) break;

                visitado[u] = true;

                for (int v = 0; v < n; v++)
                {
                    if (!visitado[v] &&
                        matrizAdyacencia[u, v] != INFINITO &&
                        distancias[u] + matrizAdyacencia[u, v] < distancias[v])
                    {
                        distancias[v] = distancias[u] + matrizAdyacencia[u, v];
                        previo[v] = u;
                    }
                }
            }

            MostrarRuta(inicio, fin, distancias, previo);
        }

        private int MinimaDistancia(int[] dist, bool[] visitado, int n)
        {
            int min = INFINITO;
            int min_index = -1;
            for (int v = 0; v < n; v++)
            {
                if (visitado[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }
            }
            return min_index;
        }

        private void MostrarRuta(int inicio, int fin, int[] distancias, int[] previo)
        {
            ActualizarListaResultadosGrafo();
            lstResultadoGrafo.Items.Add(""); 
            lstResultadoGrafo.Items.Add("--- Ruta mas corta ---");

            string strInicio = edificios[inicio];
            string strFin = edificios[fin];

            if (distancias[fin] == INFINITO)
            {
                lstResultadoGrafo.Items.Add($"No se encontro ruta de {strInicio} a {strFin}");
                return;
            }

            lstResultadoGrafo.Items.Add($"Distancia de {strInicio} a {strFin}: {distancias[fin]}");

            List<string> camino = new List<string>();
            int actual = fin;
            while (actual != -1)
            {
                camino.Add(edificios[actual]);
                actual = previo[actual];
            }
            camino.Reverse();
            lstResultadoGrafo.Items.Add("Camino: " + string.Join(" -> ", camino));
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            if (treeViewOrg.Nodes.Count == 0) return;
            lstResultadoArbol.Items.Clear();
            lstResultadoArbol.Items.Add("--- Recorrido Pre-Orden (Raiz -> Hijos) ---");

            List<string> resultados = new List<string>();
            RecorridoPreOrden(treeViewOrg.Nodes[0], resultados);
            lstResultadoArbol.Items.AddRange(resultados.ToArray());
        }

        private void RecorridoPreOrden(TreeNode nodo, List<string> listaResultados)
        {
            if (nodo == null) return;

            listaResultados.Add(nodo.Text);

            foreach (TreeNode hijo in nodo.Nodes)
            {
                RecorridoPreOrden(hijo, listaResultados);
            }
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            if (treeViewOrg.Nodes.Count == 0) return;
            lstResultadoArbol.Items.Clear();
            lstResultadoArbol.Items.Add("--- Recorrido Post-Orden (Hijos -> Raiz) ---");

            List<string> resultados = new List<string>();
            RecorridoPostOrden(treeViewOrg.Nodes[0], resultados);
            lstResultadoArbol.Items.AddRange(resultados.ToArray());
        }

        private void RecorridoPostOrden(TreeNode nodo, List<string> listaResultados)
        {
            if (nodo == null) return;

            foreach (TreeNode hijo in nodo.Nodes)
            {
                RecorridoPostOrden(hijo, listaResultados);
            }

            listaResultados.Add(nodo.Text);
        }
    }
}
  
