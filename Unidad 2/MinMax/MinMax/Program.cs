using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, min;
            int[] num = new int[2];
            max = 0;
            min = 0;
            Console.Write("Ingrese valor ");
            num[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese valor ");
            num[1] = Convert.ToInt32(Console.ReadLine());
            if (num[0] == num[1]){
                Console.WriteLine("Ambos numeros son iguales");
            }
            else{
                if (num[0] < num[1]){
                    max = num[1];
                    min = num[0];
                    Console.WriteLine("El numero mayor es {0}", max);
                    Console.WriteLine("El numero menor es {0}", min);
                }
                else{
                    max = num[0];
                    min = num[1];
                    Console.WriteLine("El numero mayor es {0}", max);
                    Console.WriteLine("El numero menor es {0}", min);
                }
            }
            Console.ReadKey();
        }
    }
}
