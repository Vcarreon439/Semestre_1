using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_3
{
    public class Monto_Venta
    {
        public int Monto;

        public void Evaluar(){
            Console.WriteLine("Ingrese monto");
            Monto = int.Parse(Console.ReadLine());
            if (Monto==0&Monto<=1000){
                Console.WriteLine("La bonificacion es de 0%");
                Console.WriteLine("Su bonificacion es de {0}",Monto*0);
            }
            if (Monto>=1001&Monto<=5000){
                Console.WriteLine("La bonificacion es de 3%");
                Console.WriteLine("Su bonificacion es de {0}", Monto * .3);
            }
            if (Monto >= 5001 & Monto <= 20000){
                Console.WriteLine("La bonificacion es de 5%");
                Console.WriteLine("Su bonificacion es de {0}", Monto * .5);
            }
            if (Monto >= 20001){
                Console.WriteLine("La bonificacion es de 8%");
                Console.WriteLine("Su bonificacion es de {0}", Monto * .8);
            }
        }
    }
}