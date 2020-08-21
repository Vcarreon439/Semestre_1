using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Prac02U4{
    class Program{
        static void Main(string[] args){
            string reini;
            int nume;
            do{
                Console.WriteLine("Que ejercicio desea evaluar?\n");
                Console.WriteLine(
                    //
                    "1.Crear un arreglo llamado numeros que almacene los siguientes datos: 20, 14, 8, 0, 5," +
                    "19 y 4 e imprime el arreglo\n" +
                    //
                    "\n2.Llenar un vector de 10 posiciones con numeros aleatorios entre 1 y 100\n" +
                    //
                    "\n3.Se tienen N empleados en una compañía y se ha ideado llenar un arreglo lineal A con " +
                     "los sueldos\n de los empleados, un arreglo B con las asignaciones totales de cada" +
                    "empleado, un arreglo C con las\n deducciones de cada uno. Crear un arreglo T que" +
                    "contenga el neto a pagar a cada empleado.\n (Neto a pagar = sueldo + asignaciones – " +
                    "deducciones)."+
                    //
                    "\n\n4.Se tienen tres arreglos unidimensionales que guardan los precios unitarios (PU)\n  las "+
                    "cantidades compradas(CC) y la descripción respectivamente de N productos distintos."+
                    "\n  Se pide:\n"+
                    "\n\t·Crear un arreglo con el total gastado en compras por producto(TG = PU * CC)"+
                    "\n\t·Calcular el total general de todas las compras."+
                    "\n\t·Mostrar la descripción y el total del producto que obtuvo mayor gasto.      " +
                    //
                    "\n\n5.Dado un arreglo A de N elementos se desea crear otro arreglo, tal que cada uno de "+
                    "sus \nelementos sea la suma de los elementos opuestos en el arreglo dado."+
                    "\nEjemplo: \nArreglo dado A = [9, 5, 3, 10, 2, 8, 1] Arreglo resultante B = [10, 13, 5, 10] " +
                    //
                    "\n\n6. Sumar los elementos de cada fila y cada columna de una matriz." +
                    "\n\n7. Metodo Alternativo del Ejercicio 6.");

                nume = int.Parse(Console.ReadLine());
                String rein;

                switch(nume){

                    //Problema 1
                    case 1:
                        do{
                            Console.Clear();
                            Console.Title = "Ejercicio 1";
                            int[] numeros = { 20, 14, 8, 0, 5, 19, 4 };
                            foreach (int numero in numeros){
                                Console.WriteLine(numero);
                            }
                            Console.WriteLine("Desea reiniciar Ejercicio 1? (S/N)\t");
                            rein = Console.ReadLine();
                            if (rein == "s" | rein == "Si" | rein == "si"){
                                rein = "S";
                            }
                        } while (rein == "S");
                        rein = null;
                        break;

                    //Problema 2
                    case 2:
                        //Llenar un vector de 10 posiciones con numeros aleatorios entre 1 y 100
                        do {
                            Console.Clear();
                            Console.Title = "Ejercicio 2";
                            int[] posici = new int[10];
                            Random rnd = new Random();
                            //Almacena los numeros aleatorios
                            for (int i = 0; i < posici.Length; i++){
                                int num = rnd.Next(100);
                                posici[i] = num;
                            }
                            //Imprime los numeros aleatorios
                            foreach (var print in posici){
                                Console.Write("{0}\t",print);
                            }
                            Console.WriteLine("\nDesea reiniciar Ejercicio 2? (S/N)\t");
                            rein = Console.ReadLine();
                            if (rein == "s" | rein == "Si" | rein == "si"){
                                rein = "S";
                            }
                        } while (rein == "S");
                        rein = null;
                        break;


                    //Problema 3
                    case 3:
                        int n;
                        do{
                            Console.Clear();
                            Console.Title = "Ejercicio 3";
                            Console.WriteLine("Cuantos empleados desea evaluar?");
                            n = int.Parse(Console.ReadLine());
                            Console.Clear();
                            double[] sueldos = new double[n];
                            double[] asignaciones = new double[n];
                            double[] deducciones = new double[n];
                            double[] neto = new double[n];
                            //Almacena sueldos, asignaciones, deducciones de cada empleado
                            for (int i = 0; i < neto.Length; i++){
                                n = i + 1;
                                Console.WriteLine("Empleado {0}", n);
                                Console.Write("Sueldo del empleado \t\t\t$");
                                sueldos[i] = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Asignaciones del empleado \t\t$");
                                asignaciones[i] = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Deducciones del empleado \t\t$");
                                deducciones[i] = Convert.ToDouble(Console.ReadLine());
                                
                            }

                            Console.ReadKey();
                            Thread.Sleep(1500);
                            Console.Clear();

                            //Almacena e imprime el neto de cada empleado
                            for (int i = 0; i < neto.Length; i++){
                                n = i + 1;
                                neto[i] = sueldos[i] + asignaciones[i] - deducciones[i];
                                Console.WriteLine("El neto del empledo {0} es de ${1}", n, neto[i]);
                            }

                            Console.ReadKey();
                            Thread.Sleep(1200);
                            Console.Clear();
                            Console.WriteLine("Desea reiniciar Ejercicio 3? (S/N)\t");
                            rein = Console.ReadLine();
                            if (rein == "s" | rein == "Si" | rein == "si"){
                                rein = "S";
                            }

                        } while (rein == "S");
                        n = 0;
                        rein = null;
                        break;

                    //Problema 4
                    case 4:
                        do{
                            Console.Clear();
                            Console.Title = "Ejercicio 4";
                            Console.WriteLine("Cuantos productos desea evaluar?");
                            n = int.Parse(Console.ReadLine());
                            double[] precioU = new double[n];
                            double[] cant = new double[n];
                            string[] descrip = new string[n];
                            double[] totgas = new double[n];
                            double total = 0, max;
                            Console.Clear();
                            //Almacena los datos de cada elemento del arreglo
                            for (int i = 0; i < totgas.Length; i++){
                                n = i + 1;
                                Console.WriteLine("Producto {0} ", n);
                                Console.Write("Descripcion\t");
                                descrip[i] = Console.ReadLine();
                                Console.Write("Precio\t\t$");
                                precioU[i] = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Cantidad\t");
                                cant[i] = Convert.ToDouble(Console.ReadLine());
                            }
                            Console.ReadKey();
                            Console.Clear();
                            //Crea el sutotal de cada producto
                            for (int i = 0; i < totgas.Length; i++){
                                totgas[i] = precioU[i] * cant[i];
                            }
                            //Crea el total de todo
                            for (int i = 0; i < totgas.Length; i++){
                                total += totgas[i];
                            }
                            //Busca el elemento mas caro;
                            max = totgas.Max();
                            //Imprime el elemento mas caro
                            Console.WriteLine("La compra mas cara fue el {0} de ${1}\n", descrip[Array.IndexOf(totgas,max)],max);
                            for (int i = 0; i < totgas.Length; i++){
                                Console.WriteLine("El subtotal de {0}, es de ${1}", descrip[i], totgas[i]);
                            }

                            Console.WriteLine("\n\nEl total de su compra es\t${0}",total);
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Desea reiniciar Ejercicio 4? (S/N)\t");
                            rein = Console.ReadLine();
                            if (rein == "s" | rein == "Si" | rein == "si"){
                                rein = "S";
                            }
                        } while (rein == "S");
                        rein = null;
                        n = 0;
                        break;
                    
                    //Problema 5
                    case 5:
                        do
                        {
                            Console.Clear();
                            Console.Title = "Ejercicio 5";
                            int nf;
                            int nuevo;
                            int resto;
                            Console.Write("ingrese tamaño de arreglo: ");
                            nf = int.Parse(Console.ReadLine());
                            //Para saber si nf es 
                            if (nf % 2 == 0){
                                //Nos servira para definir el procedimiento en caso de que sean un n par
                                nuevo = nf / 2;
                                resto = 0;
                            }
                            else{
                                //Nos servira para definir el procedimiento en caso de que sean un n impar
                                nuevo = (nf / 2) + 1;
                                resto = 1;
                            }
                            //Arreglo para numeros
                            int[] numeros = new int[nf];
                            //Arerglor para suma de opuestos
                            int[] suma = new int[nf];

                            Console.WriteLine("Tecle los " + nf + " valores");

                            //Ciclo para guardar los numeros
                            for (int i = 0; i < nf; i++){
                                Console.Write("["+i+"]" + " : ");
                                numeros[i] = int.Parse(Console.ReadLine());
                            }

                            //Ciclo que escribre los elementos del arreglo
                            Console.Write("Los elementos del arreglo son :");
                            for (int j = 0; j < numeros.Length; j++){
                                Console.Write(numeros[j] + " ");
                            }


                            Console.WriteLine("");

                            //Ciclo de la suma de los opuestos
                            Console.Write("El arreglo quedo asi:");
                            for (int i = 0; i < nuevo; i++){
                                if (numeros[i] > 0){
                                    if (i + 1 == nuevo){
                                        if (resto == 0){
                                            //Proceso en caso par
                                            suma[i] = numeros[i] + numeros[nf - i - 1];
                                            Console.Write(suma[i] + " ");
                                        }
                                        else{
                                            //Proceso en casi impar
                                            suma[i] = numeros[i] + 0;
                                            Console.Write(suma[i] + " ");
                                        }
                                    }
                                    else{
                                        suma[i] = numeros[i] + numeros[nf - i - 1];
                                        Console.Write(suma[i] + " ");
                                    }
                                }
                            }
                            Console.ReadKey();
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("Desea reiniciar Ejercicio 5? (S/N)\t");
                            rein = Console.ReadLine();
                            if (rein == "s" | rein == "Si" | rein == "si"){
                                rein = "S";
                            }
                        } while (rein == "S");
                        rein = null;
                        n = 0;
                        break;

                    //Problema 6
                    case 6:
                        do{
                            int xn, xy;
                            double suma=0,num;
                            Console.Clear();
                            Console.Title = "Ejercicio 6";
                            Console.Write("Ingrese el tamaño de x en su matriz \t");
                            xn = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el tamaño de y en su matriz \t");
                            xy = int.Parse(Console.ReadLine());
                            double[,] matriz = new double[xn,xy];
                            //Ciclo para leer y hacer la suma de todos los elementos de la matriz.
                            for (int i = 0; i < xn; i++){
                                for (int j = 0; j < xy; j++){
                                    Console.Write("Ingrese valor de elemento x[{0}], y[{1}]\t", i, j);
                                    num = Convert.ToDouble(Console.ReadLine());
                                    suma += num;
                                }
                            }

                            Console.WriteLine("El resultado de la suma de todos los elementos de la matriz es: {0}", suma);
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Desea reiniciar Ejercicio 6? (S/N)\t");
                            rein = Console.ReadLine();
                            if (rein == "s" | rein == "Si" | rein == "si"){
                                rein = "S";
                            }
                        } while (rein == "S");
                        rein = null;
                        break;

                    //Opcion 7 Alternativa de Ejercicio 6
                    case 7:
                        do{
                            Console.Clear();
                            Console.Title = "Metodo Alternativo Ejercicio 6";
                            int[,] matriz = new int[3, 3];
                            int sumaF = 0, sumaC = 0;

                            //LLENAR MATRIZ
                            for (int i = 0; i < 3; i++){
                                for (int j = 0; j < 3; j++){
                                    Console.Write("Valor matriz[" + i + "," + j + "]=");
                                    matriz[i, j] = int.Parse(Console.ReadLine());
                                }

                            }
                            //SUMAR FILAS
                            for (int i = 0; i < 3; i++){
                                for (int j = 0; j < 3; j++){
                                    sumaF = sumaF + matriz[i, j];
                                }
                                Console.WriteLine("Suma Fila " + i + "=" + sumaF);
                            }
                            Console.WriteLine("Suma Filas=" + sumaF);

                            //suma columnas
                            for (int j = 0; j < 3; j++){
                                for (int i = 0; i < 3; i++){
                                    sumaC = sumaC + matriz[i, j];
                                }
                                Console.WriteLine("Suma columna " + j + "=" + sumaC);
                            }

                            Console.WriteLine("Suma Columnas=" + sumaC);
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write("Desea reiniciar la opcion 7? (S/N)\t");
                            rein = Console.ReadLine();
                            if (rein == "s" | rein == "Si" | rein == "si"){
                                rein = "S";
                            }
                        } while (rein == "S");
                        rein = null;
                        break;

                    //En caso de no existir otro caso
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese una opcion valida");
                        Thread.Sleep(1500);
                        break;

                }
                Console.Clear();
                Console.WriteLine("Desea evaluar otro ejercicio? (S/N)");
                reini = Console.ReadLine();
                if (reini == "s" | reini == "Si" | reini == "si"){
                    reini = "S";
                }
                Console.Clear();
            } while (reini == "S");
        }
    }
}
