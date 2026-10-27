using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarDatosEnGrilla();
        }
        private void CargarDatosEnGrilla()
        {
            // 1. Crear la estructura de la tabla con las columnas de la imagen[cite: 1]
            DataTable tabla = new DataTable();
            tabla.Columns.Add("CODIGO", typeof(int));
            tabla.Columns.Add("NOMBRE", typeof(string));
            tabla.Columns.Add("APELLIDO PATERNO", typeof(string));
            tabla.Columns.Add("APELLIDO MATERNO", typeof(string));
            tabla.Columns.Add("PRACTICA 1", typeof(double));
            tabla.Columns.Add("PRACTICA 2", typeof(double));
            tabla.Columns.Add("PROYECTO FINAL", typeof(double));
            tabla.Columns.Add("PROMEDIO", typeof(double));

            // 2. Insertar las filas con los datos correspondientes[cite: 1]
            tabla.Rows.Add(400, "LUIS", "CONDORI", "QUISPE", 100, 75, 75, 82.5);
            tabla.Rows.Add(401, "MOISES", "RIVERA", "ALARCON", 75, 89, 100, 89.2);
            tabla.Rows.Add(402, "JAZMIN", "TORRES", "TORRES", 80, 100, 51, 74.4);
            tabla.Rows.Add(403, "NEIMAR", "QUISPE", "MAMANI", 70, 80, 84, 78.6);
            tabla.Rows.Add(404, "JHON", "QUISPE", "ALIAGA", 60, 58, 74, 65.0);

            // 3. Vincular la tabla al DataGridView llamado dataGridView1
            dataGridView1.DataSource = tabla;

            // 4. Ajustes visuales recomendados para que se vea ordenado
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void newForm_Click(object sender, EventArgs e)
        {
            // 1. Crear una instancia del segundo formulario
            Form2 segundoFormulario = new Form2();

            // 2. Mostrarlo
            segundoFormulario.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BUSQnOMBRE_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
