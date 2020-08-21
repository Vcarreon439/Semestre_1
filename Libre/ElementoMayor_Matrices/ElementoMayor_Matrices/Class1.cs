using System;
using System.Threading;

namespace ElementoMayor_Matrices{
    public class Matrices{

        private bool reset=false;

        public void ImprimeMatriz(){

            do {
                Console.Clear();
                    try
                    {
                        #region Variables
                        //Para el valor mas alto
                        int Mayor = 0;
                        //Valor dimension 1
                        int n;
                        //Valor dimension 2
                        int m;
                        //Valores para la posicion del elemnto de mayor valor
                        int filam = 0;
                        int colum = 0;
                        #endregion

                        Console.Write("Ingrese valor de n: \t");
                        n = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese valor de m: \t");
                        m = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        int[,] datos = new int[n, m];

                        //Llena la matriz
                        //n para dimension 1
                        //m para dimension 2
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                Console.WriteLine("Ingrese valor: matirz [{0},{1}]", i, j);
                                datos[i, j] = int.Parse(Console.ReadLine());
                            }
                        }

                        Console.WriteLine("");

                        //Saca el elemento de mayor valor y su posicion
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                if (datos[i, j] > Mayor)
                                {
                                    Mayor = datos[i, j];
                                    filam = i;
                                    colum = j;
                                }
                                Console.Write(" " + datos[i, j]);
                            }
                        }

                        Console.WriteLine("");

                        Console.WriteLine("\nEl elemento mayor de la matriz es:{0}\t", Mayor);
                        Console.WriteLine("\nLa posicion de elemento en la Matriz es: ({0},{1})", filam, colum);
                        Thread.Sleep(1200);
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine(ex.Message);
                        Thread.Sleep(1200);
                        reset = true;
                    }
            }
            while (reset==true);

        }
    }
}
