using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el monto total a pagar en soles: ");

            decimal monto = decimal.Parse(Console.ReadLine());

            int montoEnDecimos = (int)(monto * 10);

            int b100 = montoEnDecimos / 1000;

            montoEnDecimos %= 1000;

            int b50 = montoEnDecimos / 500;

            montoEnDecimos %= 500;

            int b20 = montoEnDecimos / 200;

            montoEnDecimos %= 200;

            int b10 = montoEnDecimos / 100;

            montoEnDecimos %= 100;

            int m5 = montoEnDecimos / 50;

            montoEnDecimos %= 50;

            int m2 = montoEnDecimos / 20;

            montoEnDecimos %= 20;

            int m1 = montoEnDecimos / 10;

            montoEnDecimos %= 10;

            int m05 = montoEnDecimos / 5;

            montoEnDecimos %= 5;

            int m02 = montoEnDecimos / 2;

            montoEnDecimos %= 2;

            int m01 = montoEnDecimos;

            Console.WriteLine("Distribucion del pago:");
            Console.WriteLine("Billetes de 100: " + b100);
            Console.WriteLine("Billetes de 50 : " + b50);
            Console.WriteLine("Billetes de 20 : " + b20);
            Console.WriteLine("Billetes de 10 : " + b10);
            Console.WriteLine("Monedas de 5 soles : " + m5);
            Console.WriteLine("Monedas de 2 soles : " + m2);
            Console.WriteLine("Monedas de 1 sol: " + m1);
            Console.WriteLine("Monedas de 50 céntimos : " + m05);
            Console.WriteLine("Monedas de 20 céntimos : " + m02);
            Console.WriteLine("Monedas de 10 céntimos : " + m01);
            Console.ReadKey();
        }
    }
}
