using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el sueldo del empleado: ");

            double sueldo = double.Parse(Console.ReadLine());

            double impuesto;

            if (sueldo <= 1500)

            {

                impuesto = sueldo * 0.10;

            }

            else if (sueldo <= 3000)

            {

                impuesto = (sueldo - 1500) * 0.05;

            }

            else

            {

                impuesto = (sueldo - 3000) * 0.03;

            }

            double sueldoNeto = sueldo - impuesto;

            Console.WriteLine();

            Console.WriteLine("Resultados:");

            Console.WriteLine("Impuesto retenido:  " + impuesto);

            Console.WriteLine("Sueldo neto a pagar: " + sueldoNeto);

            Console.ReadKey();
        }
    }
}
