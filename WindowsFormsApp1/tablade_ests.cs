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
        public static DataTable TABLAEST { get; set; } = new DataTable();
        public static void IniciarDatosDeTabla()
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
