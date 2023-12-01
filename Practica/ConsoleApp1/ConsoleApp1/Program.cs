using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int cant = 10;
            ClaseArrayCadenas AC = new ClaseArrayCadenas(cant);
            string[] resultadoSerie = AC.GenerarSerieExamen(cant);
            AC.MostrarArray();

            string path = "C:\\UPC\\PRO2-UPC-HOMEWORK\\Practica\\FicheroArray.txt";
            Fichero fa = new Fichero(path);
            fa.EscribirArray(AC.ArrayCadenas);
        }
    }
}
