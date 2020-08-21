using System;

namespace Promedio_2
{
    class Program
    {
        static void Main(string[] args)
        {
               int cont, lim;
               decimal sumcal, cal, prom;
               cont = 0;
               sumcal = 0;
               cal = 0;
               Console.WriteLine("Cuantas materias va a calificar?");
               lim = int.Parse(Console.ReadLine());
                   while(cont < lim) {
                       Console.WriteLine("Ingrese calificacion");
                       cal=decimal.Parse(Console.ReadLine());
                       if (cal > 10){
                           Console.WriteLine("Ingrese calificacion valida");
                           cal = decimal.Parse(Console.ReadLine());
                       }
                       sumcal = sumcal + cal;
                       cont = cont + 1;
                   }
               prom = sumcal / lim;
               Console.WriteLine("El promedio es:" + prom);

                Console.ReadLine();
        }
    }
}
