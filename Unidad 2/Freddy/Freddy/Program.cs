using System;

namespace Freddy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Funciones basicas de String:");
            string PrimerNombre = "Freddy";
            Console.WriteLine("Evalua PrimerNombre: {0}", PrimerNombre);
            Console.WriteLine("PrimerNombre tiene {0} caracteres.", PrimerNombre.Length);
            Console.WriteLine("PrimerNombre en Mayusculas: {0}", PrimerNombre.ToUpper());
            Console.WriteLine("PrimerNombre en Minusculas: {0}", PrimerNombre.ToLower());
            Console.WriteLine("PrimerNombre contiene la letra y?: {0}", PrimerNombre.Contains("y"));
            Console.WriteLine("PrimerNombre reemplaza: {0}", PrimerNombre.Replace("dy", "^^"));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
