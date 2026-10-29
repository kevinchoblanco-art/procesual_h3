using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int codEst = 0;
        string nomEst, apeP, apeM;
        int ntP1 = 0, ntP2 = 0, ntPf = 0, nota1est, nota2est, nota3est;
        double ntPR, promdEst;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool sePromedio = false;
        public Form2()
        {
            InitializeComponent();
            newCodigo.Text = tablade_ests.codigox.ToString();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            newNombre.Focus();
        }
        public int incrementarCodigo()
        {
            tablade_ests.codigox = tablade_ests.codigox + 1;
            return tablade_ests.codigox;
        }

        private void promediar_Click(object sender, EventArgs e)
        {
            try
            {
                ntP1 = int.Parse(notaPractica1.Text);
                ntP2 = int.Parse(notaPractica2.Text);
                ntPf = int.Parse(notaEvaluacion.Text);
                if (ntP1 > 100 || ntP1 < 0 || ntP2 > 100 || ntP2 < 0 || ntPf > 100 || ntPf < 0)
                {
                    notaPractica1.Text = "";
                    notaPractica2.Text = "";
                    notaEvaluacion.Text = "";
                    notaPractica1.Focus();
                    MessageBox.Show("ERROR 402: SE INGRESARON NOTAS FUERA DEL RANGO, POR FAVOR INGRESE NOTAS ENTRE 0 Y 100 :)");
                }
                else
                {
                    ntPR = (ntP1 * 0.3) + (ntP2 * 0.3) + (ntPf * 0.4);
                    mostPRomedioDeNewEst.Text = ntPR.ToString();
                    sePromedio = true;
                }
            }
            catch (FormatException)
            {
                notaPractica1.Text = "";
                notaPractica2.Text = "";
                notaEvaluacion.Text = "";
                notaPractica1.Focus();
                MessageBox.Show("ERROR 401: SE INGRESARON VALORES NO NUMERICOS O SE DEJARON ESPACIOS EN BLANCO :( ");
            }
        }

        private void newRegistro_Click(object sender, EventArgs e)
        {
            if (notaPractica1.Text == "" || notaPractica2.Text == "" || notaEvaluacion.Text == "")
            {
                notaPractica1.Text = "";
                notaPractica2.Text = "";
                notaEvaluacion.Text = "";
                notaPractica1.Focus();
                MessageBox.Show("ERROR 403 : PORFAVOR NO DEJES ESPACIOS VACIOS :)");
            }
            else
            {
                if (sePromedio == false)
                {
                    ntP1 = int.Parse(notaPractica1.Text);
                    ntP2 = int.Parse(notaPractica2.Text);
                    ntPf = int.Parse(notaEvaluacion.Text);
                    if (ntP1 > 100 || ntP1 < 0 || ntP1.ToString() == "" || ntP2 > 100 || ntP2 < 0 || ntP2.ToString() == "" || ntPf > 100 || ntPf < 0 || ntPf.ToString() == "")
                    {
                        notaPractica1.Text = "";
                        notaPractica2.Text = "";
                        notaEvaluacion.Text = "";
                        notaPractica1.Focus();
                        MessageBox.Show("ERROR 402: SE INGRESARON NOTAS FUERA DEL RANGO, POR FAVOR INGRESE NOTAS ENTRE 0 Y 100 :)");
                    }
                    else
                    {
                        ntPR = (ntP1 * 0.3) + (ntP2 * 0.3) + (ntPf * 0.4);
                        if (newNombre.Text == "" || newApellidoP.Text == "" || newApellidoM.Text == "")
                        {
                            newNombre.Focus();
                            newNombre.Text = "";
                            newApellidoP.Text = "";
                            newApellidoM.Text = "";
                            notaPractica1.Text = "";
                            notaPractica2.Text = "";
                            notaEvaluacion.Text = "";
                            mostPRomedioDeNewEst.Text = "";
                            MessageBox.Show("ERROR 403 : PORFAVOR NO DEJES ESPACIOS VACIOS :)");
                        }
                        else 
                        {
                            codEst = tablade_ests.codigox;
                            tablade_ests.codigox = incrementarCodigo();
                            nomEst = newNombre.Text;
                            apeP = newApellidoP.Text;
                            apeM = newApellidoM.Text;
                            nota1est = ntP1;
                            nota2est = ntP2;
                            nota3est = ntPf;
                            promdEst = ntPR;

                            newCodigo.Text = tablade_ests.codigox.ToString();
                            newNombre.Text = "";
                            newApellidoP.Text = "";
                            newApellidoM.Text = "";
                            notaPractica1.Text = "";
                            notaPractica2.Text = "";
                            notaEvaluacion.Text = "";
                            mostPRomedioDeNewEst.Text = "";

                            tablade_ests.codigos.Add(codEst);
                            tablade_ests.nombres.Add(nomEst);
                            tablade_ests.apellidosP.Add(apeP);
                            tablade_ests.apellidosM.Add(apeM);
                            tablade_ests.notas1.Add(nota1est);
                            tablade_ests.notas2.Add(nota2est);
                            tablade_ests.notas3.Add(nota3est);
                            tablade_ests.promedios.Add(promdEst);

                            tablade_ests.TABLAEST.Rows.Add(codEst, nomEst, apeP, apeM, nota1est, nota2est, nota3est, promdEst);
                            sePromedio = false;
                        }
                     
                        
                            
                        
                    }
                }
                else
                {
                    if (newNombre.Text == "" || newApellidoP.Text == "" || newApellidoM.Text == "")
                    {
                        newNombre.Focus();
                        newNombre.Text = "";
                        newApellidoP.Text = "";
                        newApellidoM.Text = "";
                        notaPractica1.Text = "";
                        notaPractica2.Text = "";
                        notaEvaluacion.Text = "";
                        mostPRomedioDeNewEst.Text = "";
                        MessageBox.Show("ERROR 403 : PORFAVOR NO DEJES ESPACIOS VACIOS :)");
                    }
                    else
                    {
                        codEst = tablade_ests.codigox;
                        tablade_ests.codigox = incrementarCodigo();
                        nomEst = newNombre.Text;
                        apeP = newApellidoP.Text;
                        apeM = newApellidoM.Text;
                        nota1est = ntP1;
                        nota2est = ntP2;
                        nota3est = ntPf;
                        promdEst = ntPR;

                        newCodigo.Text = tablade_ests.codigox.ToString();
                        newNombre.Text = "";
                        newApellidoP.Text = "";
                        newApellidoM.Text = "";
                        notaPractica1.Text = "";
                        notaPractica2.Text = "";
                        notaEvaluacion.Text = "";
                        mostPRomedioDeNewEst.Text = "";

                        tablade_ests.codigos.Add(codEst);
                        tablade_ests.nombres.Add(nomEst);
                        tablade_ests.apellidosP.Add(apeP);
                        tablade_ests.apellidosM.Add(apeM);
                        tablade_ests.notas1.Add(nota1est);
                        tablade_ests.notas2.Add(nota2est);
                        tablade_ests.notas3.Add(nota3est);
                        tablade_ests.promedios.Add(promdEst);

                        tablade_ests.TABLAEST.Rows.Add(codEst, nomEst, apeP, apeM, nota1est, nota2est, nota3est, promdEst);
                        sePromedio = false;
                    }
                    if (newNombre.Text == "" || newApellidoP.Text == "" || newApellidoM.Text == "")
                    {
                        newNombre.Focus();
                        newNombre.Text = "";
                        newApellidoP.Text = "";
                        newApellidoM.Text = "";
                        notaPractica1.Text = "";
                        notaPractica2.Text = "";
                        notaEvaluacion.Text = "";
                        mostPRomedioDeNewEst.Text = "";
                        MessageBox.Show("ERROR 403 : PORFAVOR NO DEJES ESPACIOS VACIOS :)");
                    }
                    else
                    {
                        codEst = tablade_ests.codigox;
                        tablade_ests.codigox = incrementarCodigo();
                        nomEst = newNombre.Text;
                        apeP = newApellidoP.Text;
                        apeM = newApellidoM.Text;
                        nota1est = ntP1;
                        nota2est = ntP2;
                        nota3est = ntPf;
                        promdEst = ntPR;

                        newCodigo.Text = tablade_ests.codigox.ToString();
                        newNombre.Text = "";
                        newApellidoP.Text = "";
                        newApellidoM.Text = "";
                        notaPractica1.Text = "";
                        notaPractica2.Text = "";
                        notaEvaluacion.Text = "";
                        mostPRomedioDeNewEst.Text = "";

                        tablade_ests.codigos.Add(codEst);
                        tablade_ests.nombres.Add(nomEst);
                        tablade_ests.apellidosP.Add(apeP);
                        tablade_ests.apellidosM.Add(apeM);
                        tablade_ests.notas1.Add(nota1est);
                        tablade_ests.notas2.Add(nota2est);
                        tablade_ests.notas3.Add(nota3est);
                        tablade_ests.promedios.Add(promdEst);

                        tablade_ests.TABLAEST.Rows.Add(codEst, nomEst, apeP, apeM, nota1est, nota2est, nota3est, promdEst);
                        sePromedio = false;
                    }
                }
            }
        }


        private void finalisarRegistro_Click(object sender, EventArgs e)
        {
            if (notaPractica1.Text == "" || notaPractica2.Text == "" || notaEvaluacion.Text == "")
            {
                notaPractica1.Text = "";
                notaPractica2.Text = "";
                notaEvaluacion.Text = "";
                notaPractica1.Focus();
                MessageBox.Show("ERROR 403 : PORFAVOR NO DEJES ESPACIOS VACIOS :)");
            }
            else
            {
                if (sePromedio == false)
                {
                    ntP1 = int.Parse(notaPractica1.Text);
                    ntP2 = int.Parse(notaPractica2.Text);
                    ntPf = int.Parse(notaEvaluacion.Text);
                    if (ntP1 > 100 || ntP1 < 0 || ntP2 > 100 || ntP2 < 0 || ntPf > 100 || ntPf < 0)
                    {
                        notaPractica1.Text = "";
                        notaPractica2.Text = "";
                        notaEvaluacion.Text = "";
                        notaPractica1.Focus();
                        MessageBox.Show("ERROR 402: SE INGRESARON NOTAS FUERA DEL RANGO, POR FAVOR INGRESE NOTAS ENTRE 0 Y 100 :)");
                    }
                    else
                    {
                        ntPR = (ntP1 * 0.3) + (ntP2 * 0.3) + (ntPf * 0.4);
                        if (newNombre.Text == "" || newApellidoP.Text == "" || newApellidoM.Text == "")
                        {
                            newNombre.Focus();
                            newNombre.Text = "";
                            newApellidoP.Text = "";
                            newApellidoM.Text = "";
                            notaPractica1.Text = "";
                            notaPractica2.Text = "";
                            notaEvaluacion.Text = "";
                            mostPRomedioDeNewEst.Text = "";
                            MessageBox.Show("ERROR 403 : PORFAVOR NO DEJES ESPACIOS VACIOS :)");
                        }
                        else
                        {
                            codEst = tablade_ests.codigox;
                            incrementarCodigo();
                            nomEst = newNombre.Text;
                            apeP = newApellidoP.Text;
                            apeM = newApellidoM.Text;
                            nota1est = ntP1;
                            nota2est = ntP2;
                            nota3est = ntPf;
                            promdEst = ntPR;


                            tablade_ests.codigos.Add(codEst);
                            tablade_ests.nombres.Add(nomEst);
                            tablade_ests.apellidosP.Add(apeP);
                            tablade_ests.apellidosM.Add(apeM);
                            tablade_ests.notas1.Add(nota1est);
                            tablade_ests.notas2.Add(nota2est);
                            tablade_ests.notas3.Add(nota3est);
                            tablade_ests.promedios.Add(promdEst);


                            tablade_ests.TABLAEST.Rows.Add(codEst, nomEst, apeP, apeM, nota1est, nota2est, nota3est, promdEst);

                            newNombre.Focus();
                            this.Close();
                            sePromedio = false;
                        }
                    }
                }
                else
                {
                    if (newNombre.Text == "" || newApellidoP.Text == "" || newApellidoM.Text == "")
                    {
                        newNombre.Focus();
                        newNombre.Text = "";
                        newApellidoP.Text = "";
                        newApellidoM.Text = "";
                        notaPractica1.Text = "";
                        notaPractica2.Text = "";
                        notaEvaluacion.Text = "";
                        mostPRomedioDeNewEst.Text = "";
                        MessageBox.Show("ERROR 403 : PORFAVOR NO DEJES ESPACIOS VACIOS :)");
                    }
                    else
                    {
                        codEst = tablade_ests.codigox;
                        tablade_ests.codigox = incrementarCodigo();
                        nomEst = newNombre.Text;
                        apeP = newApellidoP.Text;
                        apeM = newApellidoM.Text;
                        nota1est = ntP1;
                        nota2est = ntP2;
                        nota3est = ntPf;
                        promdEst = ntPR;

                        newCodigo.Text = tablade_ests.codigox.ToString();
                        newNombre.Text = "";
                        newApellidoP.Text = "";
                        newApellidoM.Text = "";
                        notaPractica1.Text = "";
                        notaPractica2.Text = "";
                        notaEvaluacion.Text = "";
                        mostPRomedioDeNewEst.Text = "";

                        tablade_ests.codigos.Add(codEst);
                        tablade_ests.nombres.Add(nomEst);
                        tablade_ests.apellidosP.Add(apeP);
                        tablade_ests.apellidosM.Add(apeM);
                        tablade_ests.notas1.Add(nota1est);
                        tablade_ests.notas2.Add(nota2est);
                        tablade_ests.notas3.Add(nota3est);
                        tablade_ests.promedios.Add(promdEst);

                        tablade_ests.TABLAEST.Rows.Add(codEst, nomEst, apeP, apeM, nota1est, nota2est, nota3est, promdEst);
                        sePromedio = false;
                    }
                    if (newNombre.Text == "" || newApellidoP.Text == "" || newApellidoM.Text == "")
                    {
                        newNombre.Focus();
                        newNombre.Text = "";
                        newApellidoP.Text = "";
                        newApellidoM.Text = "";
                        notaPractica1.Text = "";
                        notaPractica2.Text = "";
                        notaEvaluacion.Text = "";
                        mostPRomedioDeNewEst.Text = "";
                        MessageBox.Show("ERROR 403 : PORFAVOR NO DEJES ESPACIOS VACIOS :)");
                    }
                    else
                    {
                        codEst = tablade_ests.codigox;
                        tablade_ests.codigox = incrementarCodigo();
                        nomEst = newNombre.Text;
                        apeP = newApellidoP.Text;
                        apeM = newApellidoM.Text;
                        nota1est = ntP1;
                        nota2est = ntP2;
                        nota3est = ntPf;
                        promdEst = ntPR;

                        newCodigo.Text = tablade_ests.codigox.ToString();
                        newNombre.Text = "";
                        newApellidoP.Text = "";
                        newApellidoM.Text = "";
                        notaPractica1.Text = "";
                        notaPractica2.Text = "";
                        notaEvaluacion.Text = "";
                        mostPRomedioDeNewEst.Text = "";

                        tablade_ests.codigos.Add(codEst);
                        tablade_ests.nombres.Add(nomEst);
                        tablade_ests.apellidosP.Add(apeP);
                        tablade_ests.apellidosM.Add(apeM);
                        tablade_ests.notas1.Add(nota1est);
                        tablade_ests.notas2.Add(nota2est);
                        tablade_ests.notas3.Add(nota3est);
                        tablade_ests.promedios.Add(promdEst);

                        tablade_ests.TABLAEST.Rows.Add(codEst, nomEst, apeP, apeM, nota1est, nota2est, nota3est, promdEst);
                        sePromedio = false;
                    }
                }
            }
        }
    }
}