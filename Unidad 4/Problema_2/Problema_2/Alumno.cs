using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problema_2
{
    public class Alumno
    {
        public int[] Edad=new int[1];

        public void InserteDatos(){
            int dia, mes, año;
            bool aprov = true;
            Console.Write("Ingrese su año de nacimiento \t");
            año = int.Parse(Console.ReadLine());
                if (año<1900|año>2019){
                    Console.WriteLine("Ingrese año valido");
                }
                else{
                    if (2019-año>=18){
                        Console.Write("Ingrese su mes de nacimiento \t");
                        mes = int.Parse(Console.ReadLine());
                            switch (mes){
                                //Mes de enero
                                case 1:
                                Console.Write("Ingrese su dia de nacimiento \t");
                                dia = int.Parse(Console.ReadLine());
                                if (dia==0|dia>31){
                                    Console.WriteLine("Ingrese cantidad de dias correcta");}
                                else{
                                Edad[0] = 18;}
                                break;
                                //Mes de Febrero
                                case 2:
                                string bici;
                                Console.Write("Es año biciesto? (S/N)\t");
                                bici = Console.ReadLine();
                                if (bici=="S"|bici=="s"|bici=="si"|bici=="SI"){
                                Console.Write("Ingrese su dia de nacimiento \t");
                                dia = int.Parse(Console.ReadLine());
                                    if (dia == 0 | dia > 29){
                                        Console.WriteLine("Ingrese dia valido");
                                    }
                                    else{
                                        Edad[0] = 2019 - año;
                                    }
                                }
                                else{
                                Console.Write("Ingrese su dia de nacimiento \t");
                                dia = int.Parse(Console.ReadLine());
                                    if (dia == 0 | dia > 28){
                                        Console.WriteLine("Ingrese dia valido");
                                    }
                                    else{
                                        Edad[0] = 2019 - año;
                                    }
                                }
                                    break;
                                //Mes de Marzo
                                case 3:
                                Console.Write("Ingrese su dia de nacimiento \t");
                                dia = int.Parse(Console.ReadLine());
                                if (dia == 0 | dia > 31){
                                    Console.WriteLine("Ingrese cantidad de dias correcta");
                                }
                                else{
                                    Edad[0] = 2019-año;
                                }
                                    break;
                                //Mes de Abri;
                                case 4:
                                Console.Write("Ingrese su dia de nacimiento \t");
                                dia = int.Parse(Console.ReadLine());
                                if (dia == 0 | dia > 30){
                                    Console.WriteLine("Ingrese cantidad de dias correcta");
                                }
                                else{
                                    Edad[0] = 2019-año;
                                }
                                    break;
                                //Mes de Mayo
                                case 5:
                                Console.Write("Ingrese su dia de nacimiento \t");
                                dia = int.Parse(Console.ReadLine());
                                if (dia == 0 | dia > 31){
                                    Console.WriteLine("Ingrese cantidad de dias correcta");
                                }
                                else{
                                    Edad[0] = 2019-año;
                                }
                                    break;
                                //Mes de Junio
                                case 6:
                                Console.Write("Ingrese su dia de nacimiento \t");
                                dia = int.Parse(Console.ReadLine());
                                if (dia == 0 | dia > 30){
                                    Console.WriteLine("Ingrese cantidad de dias correcta");
                                }
                                else{
                                    Edad[0] = 2019-año;
                                }
                                    break;
                                //Mes de Julio
                                case 7:
                                Console.Write("Ingrese su dia de nacimiento \t");
                                dia = int.Parse(Console.ReadLine());
                                if (dia == 0 | dia > 31){
                                    Console.WriteLine("Ingrese cantidad de dias correcta");
                                }
                                else{
                                    Edad[0] = 2019 - año;
                                }
                                    break;
                                //Mes de Agosto
                                case 8:
                                Console.Write("Ingrese su dia de nacimiento \t");
                                dia = int.Parse(Console.ReadLine());
                                if (dia == 0 | dia > 31){
                                    Console.WriteLine("Ingrese cantidad de dias correcta");
                                }
                                else{
                                    Edad[0] = 2019 - año;
                                }
                                    break;
                                //Mes de Septiembre
                                case 9:
                                Console.Write("Ingrese su dia de nacimiento \t");
                                dia = int.Parse(Console.ReadLine());
                                if (dia == 0 | dia > 30){
                                    Console.WriteLine("Ingrese cantidad de dias correcta");
                                }
                                else{
                                    Edad[0] = 2019 - año;
                                }
                                    break;
                                //Mes de Octubre
                                case 10:
                                Console.Write("Ingrese su dia de nacimiento \t");
                                dia = int.Parse(Console.ReadLine());
                                if (dia == 0 | dia > 31){
                                    Console.WriteLine("Ingrese cantidad de dias correcta");
                                }
                                else{
                                    Edad[0] = 2019 - año;
                                }
                                break;
                                //Mes de noviembre
                                case 11:
                                    if (2019 - año == 18){
                                        Console.Write("Ingrese su dia de nacimiento \t");
                                        dia = int.Parse(Console.ReadLine());
                                        if (dia==0|dia>31){
                                            Console.WriteLine("Ingrese correctamente los dias");
                                        }
                                        else{
                                            if (dia == 25){
                                                Edad[0] = 17;
                                            }
                                        }
                                    }
                                    else{
                                        Console.Write("Ingrese su dia de nacimiento \t");
                                        dia = int.Parse(Console.ReadLine());
                                        if (dia == 0 | dia > 30){
                                            Console.WriteLine("Ingrese correctamente los dias");
                                        }
                                        else{
                                            Edad[0] = 2019 - año;
                                        }
                                    }
                                        break;
                                //Mes de diciembre
                                case 12:
                                Console.Write("Ingrese su dia de nacimiento \t");
                                dia = int.Parse(Console.ReadLine());
                                if (dia == 0 | dia > 31){
                                    Console.WriteLine("Ingrese cantidad de dias correcta");
                                }
                                else{
                                    Edad[0] = 2019 - año;
                                }
                                    break;
                                default:
                                    Console.WriteLine("Ingrese un mes valido");
                                    aprov = false;
                                    break;
                            }
                      
                    }
                    else{
                    //Instanciar años mayores a 2001
                    Edad[0] = 2019 - año;
                    }
                }
            if (Edad[0]>=18 & aprov==true){
                Console.WriteLine("Usted tiene {0} años de edad, por lo tanto es mayor de edad",Edad[0]);
            }
            else{
                if (aprov == true){
                    Console.WriteLine("Usted tiene {0} años de edad, por lo tanto es menor de edad", Edad[0]);
                }
            }
        }  
    }
}
