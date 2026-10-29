using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
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
        int codigoB;
        int n;
        int EA, ER;
        double Na = 0, Nb = 0, promGn;
        public Form1()
        {
            InitializeComponent();
            CargarDatosEnGrilla();
            n = tablade_ests.codigos.Count;
            if (n>0)
            {

                calcualrest(); 
                mostrar_estadisticas();
            }
        }
        private void CargarDatosEnGrilla()
        {
            tablade_ests.IniciarDatosDeTabla();
            tablaDeEstudiantes.DataSource = null;
            tablaDeEstudiantes.DataSource = tablade_ests.TABLAEST;

            tablaDeEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void newForm_Click(object sender, EventArgs e)
        {
            Form2 segundoFormulario = new Form2();
            segundoFormulario.ShowDialog();
            n = tablade_ests.codigos.Count;
            CargarDatosEnGrilla();
            calcualrest();
            mostrar_estadisticas();
            
        }

        public void buscar_Click(object sender, EventArgs e)
        {
            codigoB = int.Parse(busqCodigo.Text);
            int n = tablade_ests.codigos.Count;
            bool encontardoest = false;
            busqCodigo.Text = " ";
            busqCodigo.Focus();

            for (int i = 1; i <= n; i++)
            {
                if (i == codigoB)
                {
                    Form3 FormularioBusqueda = new Form3();
                    FormularioBusqueda.codigoenvrecb = codigoB;
                    FormularioBusqueda.Show();
                    encontardoest = true;
                    break;
                }
            }
            if (encontardoest == false)
            {
                MessageBox.Show("el codigo no existe");
            }
            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public double notaMasA ()
        {
            double guia = tablade_ests.promedios[0];
            for (int i = 0 ; i<n ; i++)
            {
                if (tablade_ests.promedios[i] > guia)
                {
                    guia = tablade_ests.promedios[i];
                }
            }
            Na = guia;
            return Na;
        }
        public double notaMasB()
        {
            double guia = tablade_ests.promedios[0];
            for (int i = 0; i < n; i++)
            {
                if (tablade_ests.promedios[i] < guia)
                {
                    guia = tablade_ests.promedios[i];
                }
            }
            Nb = guia;
            return Nb;
        }
        public double promedioDelCurso ()
        {
            double suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma = suma + tablade_ests.promedios[i];
            }
            promGn = suma / n;
            return promGn;
        }
        public int estu_aprob()
        {
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                if (tablade_ests.promedios[i] >= 51)
                {
                    suma = suma + 1;
                }
            }
            EA = suma;
            return EA;
        }
        public int estu_reprob()
        {
            int suma = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                if (tablade_ests.promedios[i] < 51)
                {
                    suma = suma + 1;
                }
            }
            ER = suma;
            return ER;
        }

        public void mostrar_estadisticas()
        {
            mostNotaMasAlta.Text = Na.ToString();
            mostNotaMasBaja.Text = Nb.ToString();
            mostPromGral.Text = promGn.ToString();
            mostREprobados.Text = ER.ToString();
            mostAprobados.Text = EA.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (n>0)
            {
                calcualrest();
                mostrar_estadisticas();
            }
        }
        public void calcualrest()
        {
            notaMasA();
            notaMasB();
            promedioDelCurso();
            estu_aprob();
            estu_reprob();
        }
    }
}
