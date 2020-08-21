using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_5
{
    public class Tablero
    {
        public string[,] TabAje =new string[8,8];

        public void LlenarTablero(){
            //Llenar espacios vacios
            for (int i = 0; i < 8; i++){
                for (int j = 0; j < 8; j++){
                    TabAje[i, j] = "-";
                }
            }
            for (int i = 0; i < 8; i++){
                for (int j = 0; j < 8; j++){
                    switch (j)
                    {
                        case 0:
                        case 7:
                            switch (i){
                                case 0:
                                case 7:
                                    TabAje[j, i] = "T";
                                    break;
                                case 1:
                                case 6:
                                    TabAje[j, i] = "C";
                                    break;
                                case 2:
                                case 5:
                                    TabAje[j, i] = "A";
                                    break;
                            }
                            break;

                        case 1:
                        case 6:
                            TabAje[j, i] = "P";
                            break;

                        case 3:
                            if (i == 0|i==7){
                                TabAje[i,j] = "M";
                            }
                            break;
                        case 4:
                            if (i == 0 | i == 7){
                                TabAje[i,j] = "R";
                            }
                            break;
                    }
                }
            }
            //Imprimir arreglo
            for (int i = 0; i < 8; i++){
                for (int j = 0; j < 8; j++){
                    Console.Write(TabAje[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}