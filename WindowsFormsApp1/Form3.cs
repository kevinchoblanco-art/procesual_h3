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
    public partial class Form3 : Form
    {
        public int codigoenvrecb { get; set; }
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load_1(object sender, EventArgs e)
        {
            busquedaPorCOdigo();
        }

        public void busquedaPorCOdigo()
        {
            int n =tablade_ests.codigos.Count+1;
            int codB = codigoenvrecb;
            for (int i = 1; i <= n; i++)
            {
                if (i == codB)
                {
                    Codigobus.Text = codB.ToString();
                    Nombrebus.Text = tablade_ests.nombres [i-1];
                    ApellidoPbus.Text = tablade_ests.apellidosP[i-1];
                    ApellidoMbus.Text = tablade_ests.apellidosM[i-1];
                    notaPractica1bus.Text = tablade_ests.notas1[i - 1].ToString();
                    notaPractica2bus.Text = tablade_ests.notas2[i - 1].ToString();
                    notaEvaluacionbus.Text = tablade_ests.notas3[i - 1].ToString();
                    mostPRomediobus.Text = tablade_ests.promedios[i - 1].ToString();
                    break;
                }
            }
        }

        private void volverInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
