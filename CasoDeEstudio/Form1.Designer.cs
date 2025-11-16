namespace CasoDeEstudio
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblResultadoArbol = new System.Windows.Forms.Label();
            this.btnProfundidad = new System.Windows.Forms.Button();
            this.btnContarNodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewOrg = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstResultadoGrafo = new System.Windows.Forms.ListBox();
            this.btnRutaMasCorta = new System.Windows.Forms.Button();
            this.btnAgregarRuta = new System.Windows.Forms.Button();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarEdificio = new System.Windows.Forms.Button();
            this.txtEdificio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 498);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblResultadoArbol);
            this.tabPage1.Controls.Add(this.btnProfundidad);
            this.tabPage1.Controls.Add(this.btnContarNodos);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.btnAgregarEmpleado);
            this.tabPage1.Controls.Add(this.txtNombreEmpleado);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.treeViewOrg);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(958, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arbol Organizativo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblResultadoArbol
            // 
            this.lblResultadoArbol.AutoSize = true;
            this.lblResultadoArbol.Location = new System.Drawing.Point(549, 144);
            this.lblResultadoArbol.Name = "lblResultadoArbol";
            this.lblResultadoArbol.Size = new System.Drawing.Size(0, 16);
            this.lblResultadoArbol.TabIndex = 7;
            // 
            // btnProfundidad
            // 
            this.btnProfundidad.Location = new System.Drawing.Point(316, 93);
            this.btnProfundidad.Name = "btnProfundidad";
            this.btnProfundidad.Size = new System.Drawing.Size(100, 23);
            this.btnProfundidad.TabIndex = 6;
            this.btnProfundidad.Text = "Profundidad";
            this.btnProfundidad.UseVisualStyleBackColor = true;
            this.btnProfundidad.Click += new System.EventHandler(this.btnProfundidad_Click);
            // 
            // btnContarNodos
            // 
            this.btnContarNodos.Location = new System.Drawing.Point(316, 64);
            this.btnContarNodos.Name = "btnContarNodos";
            this.btnContarNodos.Size = new System.Drawing.Size(151, 23);
            this.btnContarNodos.TabIndex = 5;
            this.btnContarNodos.Text = "Contar empleados";
            this.btnContarNodos.UseVisualStyleBackColor = true;
            this.btnContarNodos.Click += new System.EventHandler(this.btnContarNodos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(316, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(316, 6);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEmpleado.TabIndex = 3;
            this.btnAgregarEmpleado.Text = "Agregar";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(169, 27);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(100, 22);
            this.txtNombreEmpleado.TabIndex = 2;
            this.txtNombreEmpleado.TextChanged += new System.EventHandler(this.txtNombreEmpleado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Empleado";
            // 
            // treeViewOrg
            // 
            this.treeViewOrg.Location = new System.Drawing.Point(27, 132);
            this.treeViewOrg.Name = "treeViewOrg";
            this.treeViewOrg.Size = new System.Drawing.Size(925, 331);
            this.treeViewOrg.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstResultadoGrafo);
            this.tabPage2.Controls.Add(this.btnRutaMasCorta);
            this.tabPage2.Controls.Add(this.btnAgregarRuta);
            this.tabPage2.Controls.Add(this.txtDistancia);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cmbDestino);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmbOrigen);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnAgregarEdificio);
            this.tabPage2.Controls.Add(this.txtEdificio);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(958, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grafo de Rutas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstResultadoGrafo
            // 
            this.lstResultadoGrafo.FormattingEnabled = true;
            this.lstResultadoGrafo.ItemHeight = 16;
            this.lstResultadoGrafo.Location = new System.Drawing.Point(382, 10);
            this.lstResultadoGrafo.Name = "lstResultadoGrafo";
            this.lstResultadoGrafo.Size = new System.Drawing.Size(570, 452);
            this.lstResultadoGrafo.TabIndex = 11;
            // 
            // btnRutaMasCorta
            // 
            this.btnRutaMasCorta.Location = new System.Drawing.Point(244, 234);
            this.btnRutaMasCorta.Name = "btnRutaMasCorta";
            this.btnRutaMasCorta.Size = new System.Drawing.Size(107, 25);
            this.btnRutaMasCorta.TabIndex = 10;
            this.btnRutaMasCorta.Text = "Ruta mas corta";
            this.btnRutaMasCorta.UseVisualStyleBackColor = true;
            this.btnRutaMasCorta.Click += new System.EventHandler(this.btnRutaMasCorta_Click);
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.Location = new System.Drawing.Point(244, 193);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(107, 25);
            this.btnAgregarRuta.TabIndex = 9;
            this.btnAgregarRuta.Text = "Agregar";
            this.btnAgregarRuta.UseVisualStyleBackColor = true;
            this.btnAgregarRuta.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(127, 194);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 22);
            this.txtDistancia.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Distancia (Peso)";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(76, 133);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 24);
            this.cmbDestino.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Destino:";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(76, 71);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 24);
            this.cmbOrigen.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Origen:";
            // 
            // btnAgregarEdificio
            // 
            this.btnAgregarEdificio.Location = new System.Drawing.Point(217, 19);
            this.btnAgregarEdificio.Name = "btnAgregarEdificio";
            this.btnAgregarEdificio.Size = new System.Drawing.Size(107, 25);
            this.btnAgregarEdificio.TabIndex = 2;
            this.btnAgregarEdificio.Text = "Agregar";
            this.btnAgregarEdificio.UseVisualStyleBackColor = true;
            this.btnAgregarEdificio.Click += new System.EventHandler(this.btnAgregarEdificio_Click);
            // 
            // txtEdificio
            // 
            this.txtEdificio.Location = new System.Drawing.Point(90, 19);
            this.txtEdificio.Name = "txtEdificio";
            this.txtEdificio.Size = new System.Drawing.Size(100, 22);
            this.txtEdificio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Edificio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 522);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewOrg;
        private System.Windows.Forms.Button btnContarNodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Label lblResultadoArbol;
        private System.Windows.Forms.Button btnProfundidad;
        private System.Windows.Forms.Button btnAgregarRuta;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarEdificio;
        private System.Windows.Forms.TextBox txtEdificio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstResultadoGrafo;
        private System.Windows.Forms.Button btnRutaMasCorta;
    }
}

