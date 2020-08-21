using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3U4{
    class Llenar_metodos{
        static void full2d(double[,] arry){
            for (int i = 0; i < arry.GetLength(0); i++){
                for (int j = 0; j < arry.GetLength(1); j++){
                    Console.Write("Ingrese valor[{0},{1}]\t",i,j);
                    arry[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.Clear();
        }
        
    
    }
}
