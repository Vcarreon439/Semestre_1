using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Evidencia_Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string repet,repet2;
            do
            {
                int opc;

                Console.Clear();
                Console.Title = "Evidencia Practica 2";
                Console.WindowHeight = 35;
                Console.WriteLine("Elija una opcion: \n" +

                    //
                    "\n 1.Leer 100 numeros y obtener cubo y cuarta \n" +
                    //
                    "\n 2.Calcular e imprimir la tabla de multiplicar de un número cualquiera. " +
                    "\n Imprimir el multiplicando, el multiplicador y el producto.\n" +
                    //
                    "\n 3.Simular el comportamiento de un reloj digital, imprimiendo la hora, " +
                    "\n minutos y segundos de un día desde las 0:00:00 horas hasta las 23:59:59 horas \n" +
                    //
                    "\n 4.Calcula el sueldo de 10 empleados de la tienda Coopel y se requiere que " +
                    "\n imprima la suma de la nómina del mes de diciembre.\n" +
                    //
                    "\n 5.Escriba un programa que muestre el signo zodiacal de una persona. \n Para ello el usuario" +
                    "debe introducir únicamente el día y el mes de nacimiento \n y el programa determinará " +
                    "inmediatamente el signo zodiacal de la persona.\n" +
                    //
                    "\n 6.Calcular el factorial de un número.\n" +
                    //
                    "\n 7.Calcula el aumento de sueldo para un grupo de empleados de una empresa teniendo en " +
                    "cuenta el siguiente criterio: \n" +
                    "\n Si el sueldo es inferior a $1000: \t\t aumento 15 %" +
                    "\n Si el sueldo es mayor o igual a $1000: \t aumento 12 %\n" +
                    //
                    "\n 8.Escriba un programa que lea un numero entero N y calcule la suma de la siguiente serie: " +
                    "\n \t 11 + 22 + 33 + 44 +…..NN \n" +
                    //
                    "\n 9.Calcule el término número 180 de la secuencia de FIBONACCI. \n Recuerde que los dos " +
                    "primeros números de la serie son 0 y 1. \n El resto se calcula como la suma de los dos " +
                    "números inmediatos que le preceden.\n");
                opc = int.Parse(Console.ReadLine());
                switch (opc) {


                    //Ejercicio 1
                    case 1:
                        Console.Clear();
                        Console.Title = "Opcion 1";
                        do {
                            Console.WriteLine("\t\t\t" + "Cubo" + "\t\t\t" + "Cuarta");
                            for (int n = 1; n < 101; n++) {
                                double r, r1, r2;
                                Console.Write("\n Numero " + n + " ");
                                r = Convert.ToDouble(Console.ReadLine());
                                r1 = Math.Pow(r, 3);
                                r2 = r / 4;
                                Console.Write("\t\t\t" + r1);
                                Console.Write("\t\t\t" + r2);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write("Desea reiniciar el ejercicio 1? (S/N)" + "\t");
                            repet2 = Console.ReadLine();
                            Console.Clear();
                            if (repet2 == "S" | repet2 == "s" | repet2 == "si" | repet2 == "Si" | repet2 == "SI"){
                                repet2 = "s";
                            }
                        } while (repet2 == "s");
                        repet2 = null;
                        break;


                    //Ejercicio 2          
                    case 2:
                        Console.Clear();
                        Console.Title = "Opcion 2";
                        do {
                            double num, tabla;
                            Console.Write("Leer numero \t");
                            num = Convert.ToDouble(Console.ReadLine());

                            for (int i = 0; i < 10; i++) {
                                tabla = num * i;
                                Console.WriteLine("{0} * {1} = {2}", num, i, tabla);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write("Desea reiniciar el ejercicio 2? (S/N)" + "\t");
                            repet2 = Console.ReadLine();
                            Console.Clear();
                            if (repet2 == "S" | repet2 == "s" | repet2 == "si" | repet2 == "Si" | repet2 == "SI") {
                                repet2 = "s";
                            }
                        } while (repet2 == "s");
                        repet2 = null;
                        break;
                        
                        
                    //Ejercicio 3
                    case 3:
                        Console.Clear();
                        Console.Title = "Opcion 3";
                        do{
                        for (int i = 0; i < 24; i++) {
                            for (int j = 1; j < 60; j++) {
                                for (int k = 1; k < 60; k++) {
                                    Console.WriteLine("{0} Horas {1} Minutos {2} Segundos", i, j, k);
                                }
                            }
                        }
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write("Desea reiniciar el ejercicio 3? (S/N)" + "\t");
                            repet2 = Console.ReadLine();
                            Console.Clear();
                            if (repet2 == "S" | repet2 == "s" | repet2 == "si" | repet2 == "Si" | repet2 == "SI")
                            {
                                repet2 = "s";
                            }
                        } while (repet2 == "s");
                        repet2 = null;
                        break;


                    //Ejercicio 4
                    case 4:
                        Console.Clear();
                        Console.Title = "Opcion 4";
                        double[] sueld = new double[11];
                        sueld[0] = 0;
                        do{
                            for (int i = 1; i < 11; i++){
                                Console.Write("Ingrese sueldo de empleado " + i + "\t $");
                                sueld[i] = Convert.ToDouble(Console.ReadLine());
                                sueld[0] = sueld[0] + sueld[i];
                            }
                            Console.WriteLine("El total de la nomina es de $" + sueld[0]);
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write("Desea reiniciar el ejercicio 4? (S/N)" + "\t");
                            repet2 = Console.ReadLine();
                            Console.Clear();
                            if (repet2 == "S" | repet2 == "s" | repet2 == "si" | repet2 == "Si" | repet2 == "SI"){
                                repet2 = "s";
                            }
                        } while (repet2 == "s");
                        repet2 = null;
                        break;



                    //Ejercicio 5
                    case 5:
                        Console.Clear();
                        Console.Title = "Opcion 5";
                        string mes;
                        int dia;
                        do{
                            Console.Clear();
                            Console.Write("Cual es su dia de nacimiento \t");
                            dia = int.Parse(Console.ReadLine());
                            Console.Write("Cual es su mes de nacimiento \t");
                            mes = Console.ReadLine();

                            if (dia>31){
                                Console.WriteLine("Ingrese un dia valido");
                            }

                            //Cambiar cualquier forma de digitar el mes como cadena a un caso para el switch
                            if (mes == "enero"| mes == "1"|mes=="Enero"|mes=="ENERO"){
                                mes = "1";
                            }
                            if (mes == "febrero" | mes == "2" | mes == "Febrero" | mes == "FEBRERO"){
                                mes = "2";
                            }
                            if (mes == "marzo" | mes == "3" | mes == "Marzo" | mes == "MARZO"){
                                mes = "3";
                            }
                            if (mes == "abril" | mes == "4" | mes == "Abril" | mes == "ABRIL"){
                                mes = "4";
                            }
                            if (mes == "mayo" | mes == "5" | mes == "Mayo" | mes == "MAYO"){
                                mes = "5";
                            }
                            if (mes == "junio" | mes == "6" | mes == "Junio" | mes == "JUNIO"){
                                mes = "6";
                            }
                            if (mes == "julio" | mes == "7" | mes == "Julio" | mes == "JULIO"){
                                mes = "7";
                            }
                            if (mes == "agosto" | mes == "8" | mes == "Agosto" | mes == "AGOSTO"){
                                mes = "8";
                            }
                            if (mes == "septiembre" | mes == "9" | mes == "Septimbre" | mes == "SEPTIEMBRE"){
                                mes = "9";
                            }
                            if (mes == "octubre" | mes == "10" | mes == "Octubre" | mes == "OCTUBRE"){
                                mes = "10";
                            }
                            if (mes == "noviembre" | mes == "11" | mes == "Noviembre" | mes == "NOVIEMBRE"){
                                mes = "11";
                            }
                            if (mes == "diciembre" | mes == "12" | mes == "Diciembre" | mes == "DICIEMBRE"){
                                mes = "12";
                            }

                            //Para que concuerde con los meses que tienen 30 dias
                            if (mes == "4" | mes == "6" | mes == "9" | mes == "11" & dia > 30){
                                Console.WriteLine("Ingrese un dia valido");
                            }
                            //Para que concuerde con los meses que tienen 31 dias
                            if (mes == "1" | mes == "3" | mes == "5" | mes == "7"|mes=="8"|mes=="10"|mes=="12" & dia > 31){
                                Console.WriteLine("Ingrese un dia valido");
                            }
                            //Para que concuerde con el mes que tiene 28 dias
                            if (mes == "2"&dia>28){
                                Console.WriteLine("Ingrese dia valido");
                            }

                            Console.Clear();

                            switch (mes){

                                //Enero
                                case "1":
                                    if (dia >= 1 & dia <= 19){
                                        Console.WriteLine("Usted es Capricornio");
                                    }
                                    else{
                                        if (dia >= 20 & dia <= 31){
                                            Console.WriteLine("Usted es Acuario");
                                        }
                                    }
                                    break;

                                //Febrero
                                case "2":
                                    if (dia >= 1 & dia <= 18){
                                        Console.WriteLine("Usted es Acuario");
                                    }
                                    else {
                                        if (dia>=19&dia<=28){
                                            Console.WriteLine("Usted es Picis");

                                        }
                                    }
                                    break;

                                //Marzo
                                case "3":
                                    if (dia>=1&dia<=19){
                                        Console.WriteLine("Usted es Picis");
                                    }
                                    else{
                                        if (dia>=20&dia<=31){
                                            Console.WriteLine("Usted es Aries");
                                        }
                                    }
                                    break;

                                //Abril
                                case "4":
                                    if (dia>=1&dia<=18){
                                        Console.WriteLine("Usted es Aries");
                                    }
                                    else{
                                        if (dia>=19&dia<=31){
                                            Console.WriteLine("Usted es Tauro");
                                        }
                                    }
                                    break;

                                //Mayo
                                case "5":
                                    if (dia >= 1 & dia <= 19){
                                        Console.WriteLine("Usted es Tauro");
                                    }
                                    else{
                                        if (dia >= 20 & dia <= 31){
                                            Console.WriteLine("Usted es Geminis");
                                        }
                                    }
                                    break;

                                //Junio
                                case "6":
                                    if (dia >= 1 & dia <= 20){
                                        Console.WriteLine("Usted es Geminis");
                                    }
                                    else{
                                        if (dia >= 21 & dia <= 30){
                                            Console.WriteLine("Usted es Cancer");
                                        }
                                    }
                                    break;

                                //Julio
                                case "7":
                                    if (dia >= 1 & dia <= 21){
                                        Console.WriteLine("Usted es Cancer");
                                    }
                                    else{
                                        if (dia >= 22 & dia <= 31){
                                            Console.WriteLine("Usted es Leo");
                                        }
                                    }
                                    break;

                                //Agosto
                                case "8":
                                    if (dia >= 1 & dia <= 21)                                    {
                                        Console.WriteLine("Usted es Leo");
                                    }
                                    else{
                                        if (dia >= 22 & dia <= 31){
                                            Console.WriteLine("Usted es Virgo");
                                        }
                                    }
                                    break;

                                //Septiembre
                                case "9":
                                    if (dia >= 1 & dia <= 21){
                                        Console.WriteLine("Usted es Virgo");
                                    }
                                    else{
                                        if (dia >= 22 & dia <= 30){
                                            Console.WriteLine("Usted es Libra");
                                        }
                                    }
                                    break;

                                //Octubre
                                case "10":
                                    if (dia >= 1 & dia <= 22){
                                        Console.WriteLine("Usted es Libra");
                                    }
                                    else{
                                        if (dia >= 23 & dia <= 31){
                                            Console.WriteLine("Usted es Escorpio");
                                        }
                                    }
                                    break;

                                //Noviembre
                                case "11":
                                    if (dia >= 1 & dia <= 20){
                                        Console.WriteLine("Usted es Escorpio");
                                    }
                                    else{
                                        if (dia >= 21 & dia <= 30){
                                            Console.WriteLine("Usted es Sagitario");
                                        }
                                    }
                                    break;

                                //Diciembre
                                case "12":
                                    if (dia >= 1 & dia <= 20){
                                        Console.WriteLine("Usted es Sagitario");
                                    }
                                    else{
                                        if (dia >= 21 & dia <= 31){
                                            Console.WriteLine("Usted es Capricornio");
                                        }
                                    }
                                    break;

                                default:
                                    Console.WriteLine("Ingrese un mes valido");
                                    break;
                            }

                            Console.ReadKey();
                            Console.Clear();
                            Console.Write("Desea reiniciar el ejercicio 5? (S/N)" + "\t");
                            repet2 = Console.ReadLine();
                            if (repet2 == "S" | repet2 == "s" | repet2 == "si" | repet2 == "Si" | repet2 == "SI"){
                                repet2 = "s";
                            }
                        } while (repet2 == "s");


                        break;


                    //Ejercicio 6
                    case 6:
                        Console.Clear();
                        Console.Title = "Ejercicio 6";
                        do{
                            int f;
                            double fact=1;
                            Console.Write("Ingrese numero a evaluar: ");
                            f = int.Parse(Console.ReadLine());
                            Console.Write("{0}!=",f);
                            //Realiza las operaciones
                            for (int i = 1; i <= f; i++){
                                fact *= i;    
                            }
                            //Imprime factorial (Ejeplo 5x4x3x2x1)
                            for (int j = f; j > 0; j--){
                                if (j == 1){
                                    Console.Write(j);
                                }
                                else{
                                    Console.Write(j + " x ");
                                }
                            }
                            Console.Write(" = "+fact);
                            Console.ReadKey();
                            //Evalua si desea reiniciar el ejercicio
                            Console.Clear();
                            Console.WriteLine("Desea reiniciar al algoritmo? (S/N)" + "\t");
                            repet2 = Console.ReadLine();
                            Console.Clear();
                            if (repet2 == "S" | repet2 == "s" | repet2 == "si" | repet2 == "Si" | repet2 == "SI"){
                                repet2 = "s";
                            }
                        } while (repet2 == "s");
                        repet2 = null;
                        break;
                        

                    //Ejercicio 7
                    case 7:
                        Console.Clear();
                        Console.Title = "Opcion 7";
                        do {
                            int n2;
                            double s, s2 = 0;
                            Console.Write("Cuantos empleados desea evaluar? \t");
                            n2 = int.Parse(Console.ReadLine());
                            double[] suelds = new double[n2];

                            for (int i = 0; i < n2; i++) {
                                Console.Write("Sueldo del " + (i + 1) + " empleado \t $");
                                s = Convert.ToDouble(Console.ReadLine());
                                if (s < 1000) {
                                    s = s * 1.15;
                                }
                                else {
                                    if (s >= 1000) {
                                        s = s * 1.12;
                                    }
                                }
                                suelds[i] = s;
                            }

                            for (int i = 0; i < n2; i++) {
                                s2 += suelds[i];
                            }
                            Console.Clear();
                            Console.Write("El total de la nomina es de: \t $" + s2);
                            Console.ReadKey();
                            //Evalua si desea reiniciar el ejercicio
                            Console.Clear();
                            Console.Write("Desea reiniciar el ejercicio 7? (S/N)" + "\t");
                            repet2 = Console.ReadLine();
                            Console.Clear();
                            if (repet2 == "S" | repet2 == "s" | repet2 == "si" | repet2 == "Si" | repet2 == "SI"){
                                repet2 = "s";
                            }
                        } while (repet2 == "s");
                        break;

                    //Ejercicio 8
                    case 8:
                        Console.Clear();
                        Console.Title = "Opcion 8";
                        do{
                        int n,n2;
                        double r=0;
                        Console.Write("Digite un numero \t");
                        n = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= n; i++){
                                    n2 = i * 11;
                                    r += n2;
                                if (i < n){
                                    Console.Write(n2 + " + ");
                                }
                                else{
                                    Console.Write(n2 + " = ");
                                }
                        }
                        Console.Write(r);
                            Console.ReadKey();
                            //Evalua si desea reiniciar el ejercicio
                            Console.Clear();
                            Console.Write("Desea reiniciar el ejercicio 8? (S/N)" + "\t");
                            repet2 = Console.ReadLine();
                            Console.Clear();
                            if (repet2 == "S" | repet2 == "s" | repet2 == "si" | repet2 == "Si" | repet2 == "SI")
                            {
                                repet2 = "s";
                            }
                        } while (repet2 == "s");
                        break;

                    //Ejercicio 9
                    case 9:
                      Console.Clear();
                      Console.Title = "Opcion 9";
                      ulong nfn1=1,nfn2=0;
                      ulong resultado, res2=0;
                      Console.WriteLine("0");
                      Console.WriteLine("1");
                        for (int fn = 0; fn <= 90; fn++){
                          resultado = nfn1 + nfn2;
                          nfn2 = nfn1;
                          nfn1 = resultado;
                          res2 = resultado;
                          Console.WriteLine(resultado);
                      }
                        Console.WriteLine("\n\n"+res2);
                      Console.ReadKey();
                      break;
                      


                    default:
                        Console.Clear();
                        Console.Write("Escoja una opcion valida");
                        Thread.Sleep(1200);
                        break;
                }
                Console.Clear();
                Console.Write("Desea Evaluar otro ejercicio? (S/N) \t");
                repet = Console.ReadLine();


                if (repet == "S" | repet == "s" | repet == "si" | repet == "Si" | repet == "SI"){
                    repet = "s";
                }
                
            }
            while (repet == "s");

            
        }
    }
}
