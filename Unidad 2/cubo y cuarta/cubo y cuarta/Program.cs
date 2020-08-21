using System;

namespace cubo_y_cuarta
{
    class Program
    {
        static void Main(string[] args)
        {
            int lim;
            double num, cubo, cuarta;
            lim = 10;
            //Siclo para 10
            for (int cont = 0; cont < lim; cont++){
                Console.WriteLine("Escriba numero a evaluar");
                num = double.Parse(Console.ReadLine());
                cuarta = num / 4;
                cubo = Math.Pow(num, 2);
                Console.WriteLine(cuarta);
                Console.WriteLine(cubo);
            }
            Console.ReadKey();
        }
    }
}
