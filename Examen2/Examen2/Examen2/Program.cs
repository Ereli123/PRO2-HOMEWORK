using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            MatrizCadenas MC = new MatrizCadenas(8, 8);
            MC.CargarMatrizDefault();

            for (int i = 0; i < 8; i++)
            {
                MC.Insertar(i, 1, "Blanco");
            }

            MC.Insertar(1, 0, "Blanco");
            MC.Insertar(3, 0, "Blanco");
            MC.Insertar(5, 0, "Blanco");
            MC.Insertar(7, 0, "Blanco");

            MC.MoverWhitePeon(1, 1);
            MC.MoverWhitePeon(3, 1);
            MC.MoverWhitePeon(5, 1);
            MC.MoverWhitePeon(7, 1);




            for (int i = 0; i < 8; i++)
            {
                MC.Insertar(i, 6, "Rojo");
            }

            MC.Insertar(0, 7, "Rojo");
            MC.Insertar(2, 7, "Rojo");
            MC.Insertar(4, 7, "Rojo");
            MC.Insertar(6, 7, "Rojo");

            MC.MoverBlackPeon(0, 6);
            MC.MoverBlackPeon(2, 6);
            MC.MoverBlackPeon(4, 6);
            MC.MoverBlackPeon(6, 6);

            MC.MostrarMatriz();


            //recursividad impar
        }
    }
}