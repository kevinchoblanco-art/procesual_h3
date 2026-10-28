using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public string DatoRecibido { get; set; }
        public Form1()
        {
            InitializeComponent();
            CargarDatosEnGrilla();
        }
        private void CargarDatosEnGrilla()
        {
            tablade_ests.IniciarDatosDeTabla();
            tablaDeEstudiantes.DataSource = null;
            tablaDeEstudiantes.DataSource = tablade_ests.TABLAEST;

          
            tablaDeEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Formulario_Load(object sender, EventArgs e)
        {
            tablade_ests.IniciarDatosDeTabla();
            tablaDeEstudiantes.DataSource = tablade_ests.TABLAEST;
        }
        private void Formulario_Activated(object sender, EventArgs e)
        {
            tablaDeEstudiantes.DataSource = null;
            tablaDeEstudiantes.DataSource = tablade_ests.TABLAEST;
        }

        private void newForm_Click(object sender, EventArgs e)
        {
            Form2 segundoFormulario = new Form2();
            segundoFormulario.DatoRecibido = "tablaDeEstudiantes";
            segundoFormulario.Show();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            Form3 FormularioBusqueda = new Form3();
            FormularioBusqueda.Show();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
