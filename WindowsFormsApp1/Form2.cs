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
    public partial class Form2 : Form
    {
        public string DatoRecibido { get; set; }
        public Form2()
        {
            InitializeComponent();
            newCodigo.Text = codigo.ToString();
            newNombre.Text = " ";
            newNombre.Focus();
        }
        int codigo = 400;
        int codEst = 0;
        string nomEst, apeP, apeM;
        int ntP1 = 0, ntP2 = 0, ntPf = 0, nota1est, nota2est, nota3est;
        double ntPR, promdEst;

        private void promediar_Click(object sender, EventArgs e)
        {
            ntP1 = int.Parse(notaPractica1.Text);
            ntP2 = int.Parse(notaPractica2.Text);
            ntPf = int.Parse(notaEvaluacion.Text);
            ntPR = (ntP1 * 0.3) + (ntP2 * .03) + (ntPf * 0.4);
            mostPRomedioDeNewEst.Text = ntPR.ToString();
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void finalisarRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newRegistro_Click(object sender, EventArgs e)
        {
            codEst = codigo;
            codigo = codigo + 1;
            nomEst = newNombre.Text;
            apeP = newApellidoP.Text;
            apeM = newApellidoM.Text;
            promdEst = ntPR;
            nota1est = ntP1;
            nota2est = ntP2;
            nota3est = ntPf;
            newNombre.Focus();
        }
    }
}