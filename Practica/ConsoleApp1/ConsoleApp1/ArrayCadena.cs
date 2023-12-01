using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ClaseArrayCadenas
{
    public string[] ArrayCadenas;

    public ClaseArrayCadenas()
    {
        ArrayCadenas = new string[0];
    }

    public ClaseArrayCadenas(int cant)
    {
        ArrayCadenas = new string[cant];
    }

    public void MostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            resp += ArrayCadenas[i] + ", ";
        }
        Console.WriteLine(resp + "]");
    }

    public string[] GenerarSerieExamen(int cantidadElementos)
    {
        int numA = 1;
        int numB = 2;
        bool sw = true;
        for (int i = 0; i < cantidadElementos; i++)
        {
            if (sw)
            {
                ArrayCadenas[i] = numA + "";
                numA = numA + 5;
                sw = false;
            }
            else
            {
                ArrayCadenas[i] = numB + "";
                numB = numB + 2;
                sw = true;
            }
        }
        return ArrayCadenas;
    }
}