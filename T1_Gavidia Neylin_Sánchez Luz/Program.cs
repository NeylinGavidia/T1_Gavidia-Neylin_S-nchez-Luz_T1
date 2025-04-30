using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Gavidia_Neylin_Sánchez_Luz
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Cuántos billetes de 50, 10, 20 y 100 soles y monedas de 0.1, 0.2, 0.5, 1, 2 y 5 soles recibirán un empleado como pago por su trabajo? Suponga que se le debe entregar la máxima cantidad posible de billetes y monedas de cada denominación//
            Console.WriteLine("Bienvenido a su banco, para retirar, por favor.Ingrese el sueldo que recibe");
            double sueldo = float.Parse(Console.ReadLine());
            if (sueldo>100)
            {
                double cien = sueldo/100;
                double entero = Math.Truncate(cien);
                double sobra1 = sueldo % 100;

                if (sobra1 >= 50) {

                    double dec = sobra1 / 50;
                    double e2 = Math.Truncate(dec);
                    double sobra2 = sobra1 - 50;

                    if (sobra2 >= 40)
                    {
                        double sobra3 = sobra2 / 20;

                        double e3 = Math.Truncate(sobra3);

                        double ss1 = sobra2 % 20;

                        if (ss1 <= 10)
                        {
                            double ss2 = ss1 / 5;

                            double e4 = Math.Truncate(ss2);

                            double ss3 = ss1 % 5;

                            if (ss3 >= 2)
                            {
                                double ss4 = ss3 / 2;

                                double e5 = Math.Truncate(ss4);

                                double ss5 = ss3 % 2;

                                if (ss5 >= 0.5)
                                {
                                    double ss6 = ss5 / 0.5;

                                    double e6 = Math.Truncate(ss6);

                                    double ss7 = ss5 % 0.5;

                                    if (ss7 >= 0.4)
                                    {
                                        double ss8 = ss7 / 0.2;

                                        double e7 = Math.Truncate(ss8);

                                        double ss9 = ss7 % 2;
                                        Console.WriteLine("Se entregarán " + entero + " billetes de 100, " + e2 + " billetes de 50, " + e3 + " billetes de 20, " + e4 + " monedas de 5 soles," + e5 + " monedas de 2 soles, " + e6 + " monedas de 50 centimos y " + e7 + " monedas de 20 centimos");
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }
    }
}
