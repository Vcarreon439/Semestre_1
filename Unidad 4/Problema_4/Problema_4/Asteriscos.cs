using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_4
{
    public class Asteriscos
    {
        public void ImprimeAsteriscos(){
            Console.WriteLine("Ingrese un numero");
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n,n];

            //Llenar espacios vacios
            for (int i = 0; i < matrix.GetLength(0); i++){
                for (int j = 0; j < matrix.GetLength(1); j++){
                    matrix[i, j] = ' ';
                }
            }
            //Llena horizontales
            for (int i = 0; i < matrix.GetLength(0); i++){
                for (int j = 0; j < matrix.GetLength(1); j++){
                    if (i==0|i==matrix.GetLength(1)-1){
                        matrix[i, j] = '*';
                    }
                }
            }
            //Llena verticales
            for (int i = 0; i < matrix.GetLength(0); i++){
                for (int j = 0; j < matrix.GetLength(1); j++){
                    if (j == 0|j==matrix.GetLength(1)-1){
                        matrix[i, j] = '*';
                    }
                }
            }
            //Imprime arreglo
            for (int i = 0; i < matrix.GetLength(0); i++){
                for (int j = 0; j < matrix.GetLength(1); j++){
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}