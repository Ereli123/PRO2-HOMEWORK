using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion5
{
    public class Vid6_Empleados
    {
        public Vid6_Empleados() 
        {
            Nombre = "";
            SueldoDiario = 0.0m;
            Edad = 0;
        }

        public string Nombre;
        public decimal SueldoDiario;
        public int Edad;

        public decimal CalculaSalario(int NumeroDias) 
        { 
            return SueldoDiario * NumeroDias;
        }
    }
}
