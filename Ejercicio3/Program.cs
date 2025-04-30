using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero positivo de 3 cifras:");

            int numero = int.Parse(Console.ReadLine());

            if (numero >= 100 && numero <= 999)

            {

                double cien = numero / 100;
                double e1 = Math.Truncate(cien);
                double aux1 = numero % 100;
                double diez = aux1 / 10;
                double aux2 = aux1 % 10;
                double e2 = Math.Truncate(diez);
                double aux3 = aux2 / 1;
                double suma = e1 + e2 + aux3;

                Console.WriteLine("La suma de los dígitos de " + numero + "(" + e1 + " + " + e2 + " + " + aux3 + "), es: " + suma);

            }

            else

            {

                Console.WriteLine("Error: El número debe tener 3 cifras.");

            }

            Console.ReadKey();
        }
    }
}
