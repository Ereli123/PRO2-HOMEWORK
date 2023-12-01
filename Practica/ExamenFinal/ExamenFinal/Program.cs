using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Examen Final");
            //PREGUNTA RECURSIVO TO ITERATIVO
            int cant = 10;
            ClaseArrayCadenas AC = new ClaseArrayCadenas(cant);
            string[] resultadoSerie = AC.GenerarSerieExamenFinal(cant);
            AC.MostrarArray();

            string path = "C:\\UPC\\PRO2-UPC-HOMEWORK\\ExamenFinal\\SerieIterativo.txt";
            Fichero fa = new Fichero(path);
            fa.EscribirArray(AC.ArrayCadenas);
            /*
           for(int i = 0; i < resultadoSerie.Length; i++)
           {
               ClaseArrayCadenas A = new ClaseArrayCadenas(cant);
               string[] SerieFinal = A.GenerarSerieExamenFinal(cant);
               string pathFor = "C:\\UPC\\PRO2-UPC-HOMEWORK\\ExamenFinal\\for" + i + ".txt";
               AC.MostrarArray(pathFor, SerieFinal);
           }
            */

                DateTime timeInicio = DateTime.Now;
                Console.WriteLine("Inicio: " +  timeInicio);
            Fichero f = new Fichero(path); 
            for (int i = 0; i < resultadoSerie.Length; i++)
            { 
                
            }
        }

        
    }
}