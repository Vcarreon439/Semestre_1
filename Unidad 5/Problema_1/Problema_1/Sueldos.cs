using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problema_1
{
    public class Sueldos
    {
        public double nomina;

        public void CalcularNomina()
        {
            nomina = 0;
            double[] sueldos = new double[5];
            for (int i = 0; i < 5; i++){
                Console.Write("Inserte {0} sueldo\t$", i + 1);
                sueldos[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++){
                nomina += sueldos[i];
            }
            Console.Clear();
            Console.WriteLine("El total de la nomina es ${0}", nomina);
        }
    }
}
