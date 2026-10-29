using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class tablade_ests
    {
        public static int codigox = 1;
        public static DataTable TABLAEST { get; set; } = new DataTable();
        public static List<int> codigos = new List<int>();
        public static List<string> nombres = new List<string>();
        public static List<string> apellidosP = new List<string>();
        public static List<string> apellidosM = new List<string>();
        public static List<int> notas1 = new List<int>();
        public static List<int> notas2 = new List<int>();
        public static List<int> notas3 = new List<int>();
        public static List<double> promedios = new List<double>();


        public static void IniciarDatosDeTabla()
        {
            if (TABLAEST.Columns.Count == 0)
            {
                TABLAEST.Columns.Add("CODIGO", typeof(int));
                TABLAEST.Columns.Add("NOMBRE", typeof(string));
                TABLAEST.Columns.Add("APELLIDO PATERNO", typeof(string));
                TABLAEST.Columns.Add("APELLIDO MATERNO", typeof(string));
                TABLAEST.Columns.Add("PRACTICA 1", typeof(double));
                TABLAEST.Columns.Add("PRACTICA 2", typeof(double));
                TABLAEST.Columns.Add("PROYECTO FINAL", typeof(double));
                TABLAEST.Columns.Add("PROMEDIO", typeof(double));
            }
        }
    }
}
