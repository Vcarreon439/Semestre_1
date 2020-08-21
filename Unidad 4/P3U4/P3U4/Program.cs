using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace P3U4{
    class Program{
        static void Main(string[] args){
            int cas;
            string reini;
            Console.Title = "Evidencia Practica 3";
            Console.WriteLine("Elige una opcion: \n");
            Console.WriteLine("1.El	programa pide al usuario los elementos de una matriz de 6X4, calcula la	suma de	los " +
            "elementos cada fila\n y la guarda en un vector(arreglo), tambien determina la suma de" +
            "los elementos de cada columna y la guarda \nen otro vector y al final imprime los dos" +
            "vectores.\n" +
                "\n2.Realice la multimplicacion de una matriz de 5X5\n" +
                "\n3.El programa se declara una matriz de 3 dimensiones que utiliza tres indices para" +
                "guardar datos: \ni(ancho), j(largo), k(altura) si es que lo visualizamos como un cubo.\nSolo " +
                "puede almacenar 3 datos por indice([3][3][3]), por lo que seria un cubo de 3X3." +
                "\nImprime los datos que contenga la  matriz.\n");
            cas = int.Parse(Console.ReadLine());
            do
            {
                switch (cas) {

                    case 1:
                        Console.Clear();
                        Console.Title = "Ejercicio 1";
                        Console.WriteLine("Ingrese cantidad de filas");
                        int fila = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese cantidad de Columnas");
                        int col = int.Parse(Console.ReadLine());
                        double[,] array = new double[fila, col];
                        double[] sumf = new double[fila];
                        double[] sumc = new double[col];
                        full2d(array);
                        for (int i = 0; i < array.GetLength(0); i++){
                            for (int j = 0; j < array.GetLength(1); j++){
                                sumf[i] = sumf[i] + array[i, j];
                            }
                        }
                        for (int i = 0; i < array.GetLength(0); i++){
                            for (int j = 0; j < array.GetLength(1); j++){
                                sumc[j] = sumc[j] + array[i, j];
                            }
                        }
                        Console.WriteLine("El resultado de la suma de las filas es:");
                        Console.Write("(");
                        foreach (var copia in sumf){
                            Console.Write(" "+copia);
                        }
                        Console.Write(")");
                        Console.WriteLine();
                        Console.WriteLine("Y resultado de la suma de las columnas es:");
                        Console.Write("(");
                        foreach (var copia in sumc){
                            Console.Write(" "+copia);
                        }
                        Console.Write(")");
                        Console.ReadLine();
                        Thread.Sleep(1500);
                        fila = 0;
                        col = 0;
                        break;

                    case 2:
                        Console.Clear();
                        Console.Title = "Ejercico 2";
                        Console.Write("Ingrese catidad de filas \t");
                        fila = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese catidad de columnas \t");
                        col = int.Parse(Console.ReadLine());
                        ulong[,] matrixx = new ulong[fila,col];
                        full2dul(matrixx);
                        ulong mult = 1;
                        for (int i = 0; i < matrixx.GetLength(0); i++){
                            for (int j = 0; j < matrixx.GetLength(1); j++){
                                mult = mult * matrixx[i, j];
                            }
                        }
                        Console.WriteLine("El resultado es de {0}", mult);
                        Console.ReadKey();
                        Thread.Sleep(1000);
                        fila = 0;
                        col = 0;
                        break;


                    case 3:
                        Console.Clear();
                        Console.Title = "Ejercicio 3";
                        Console.Write("Ingrese cantidad de filas\t");
                        fila = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese cantidad de Columnas\t");
                        col = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese profundidad\t");
                        int prof = int.Parse(Console.ReadLine());
                        int[,,] matri = new int[fila, col, prof];
                        full3d(matri);
                        Console.Clear();
                        Thread.Sleep(1000);
                        for (int i = 0; i < matri.GetLength(2); i++){
                            Console.WriteLine("Dimension {0}",i);
                            for (int j = 0; j < matri.GetLength(0); j++){
                                for (int k = 0; k < matri.GetLength(1); k++){
                                    Console.WriteLine("[{0},{1}]={2}",j,k,matri[i,j,k]); ;
                                }
                            }
                        }
                        Console.ReadKey();
                        Thread.Sleep(1500);
                        break;
                    default:
                        Console.WriteLine("Ingrese opcion valida");
                        Thread.Sleep(1500);
                        break;
                }
                Console.Clear();
                Console.Write("Desea reiniciar el programa? (S/N)\t");
                reini = Console.ReadLine();
                if (reini == "s" | reini == "si" | reini == "SI"){
                    reini = "S";
                }
            } while (reini=="S");
            Console.ReadKey();
        }
        static void full2d(double[,] arry){
            for (int i = 0; i < arry.GetLength(0); i++){
                for (int j = 0; j < arry.GetLength(1); j++){
                    Console.Write("Ingrese valor[{0},{1}]\t", i, j);
                    arry[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.Clear();
        }

        static void full2dul(ulong[,] arry){
            for (int i = 0; i < arry.GetLength(0); i++){
                for (int j = 0; j < arry.GetLength(1); j++){
                    Console.Write("Ingrese valor[{0},{1}]\t", i, j);
                    arry[i, j] = Convert.ToUInt64(Console.ReadLine());
                }
            }
            Console.Clear();
        }

        static void full3d(int[,,] arry){
            for (int i = 0; i < arry.GetLength(0); i++){
                for (int j = 0; j < arry.GetLength(1); j++)
                    for (int k = 0; k < arry.GetLength(2); k++){
                        Console.Write("Ingrese valor[{0},{1},{2}]\t", i, j, k);
                        arry[i,j,k] = int.Parse(Console.ReadLine());
                    }
            }
            Console.Clear();
        }

    }
}
