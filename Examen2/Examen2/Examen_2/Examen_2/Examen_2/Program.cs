using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            MostrarDigImparesRecursivo(78568168);
        }


        public static void MostrarDigImparesIterativo(int N)
        {
            int NroAux = N;
            while (NroAux != 0)
            {
                int dig = NroAux % 10;
                if (dig % 2 != 0)
                {
                    Console.WriteLine("Dig: " + dig);
                }
                NroAux = NroAux / 10;
            }
        }

        public static void MostrarDigImparesRecursivo(int N)
        {
            int NroAux = N;
            if (NroAux == 0)
            {
                return;
            }
            else
            {
                int dig = NroAux % 10;
                if (dig % 2 != 0)
                {
                    Console.WriteLine("Dig: " + dig);
                }
                MostrarDigImparesRecursivo(NroAux / 10);

            }
        }



    }
}