using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion5
{
    class Vid6_Program
    {
        static void Main(string[] args)
        {
            Vid6_Empleados empleado;
            empleado = new Vid6_Empleados();
            empleado.Edad = 20;
            empleado.Nombre = "Ereli Ruiz";
            empleado.SueldoDiario = 12.5m;
            decimal total;
            total = empleado.CalculaSalario(30);
            Console.WriteLine("El salario mensual del empleado " + empleado.Nombre);
            Console.WriteLine("es: " + total.ToString("C"));
            Console.ReadKey();

        }
    }
}
