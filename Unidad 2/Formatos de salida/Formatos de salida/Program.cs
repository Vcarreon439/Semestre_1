using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatos_de_salida
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("La Evaluacion 99999 en varios formatos:");
            Console.WriteLine("c formato: {0:c}", 99999); //Moneda
            Console.WriteLine("d9 formato: {0:d9}", 99999); // Numero decimal
            Console.WriteLine("f3 formato: {0:f3}", 99999);//Punto decimal fijo
            Console.WriteLine("n formato: {0:n}", 99999);//Formato comas
            Console.WriteLine("E formato: {0:E}", 99999);//Notación exponencial
            Console.WriteLine("e formato: {0:e}", 99999);
            Console.WriteLine("X formato: {0:X}", 99999); //Formato Hexadecimal
            Console.WriteLine("x formato: {0:x}", 99999);
            Console.ReadKey();
        }
    }
}
