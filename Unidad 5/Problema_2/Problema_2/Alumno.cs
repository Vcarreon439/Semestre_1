using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problema_2
{
    public class Alumno
    {
        public int[] Edad;

        public void InserteDatos()
        {

            int dia, mes, año;
            Console.Write("Ingrese su año de nacimiento \t");
            año = int.Parse(Console.ReadLine());
            if (2019 - año < 18){
                Console.WriteLine("Usted es menor de edad");
            }
            else{
                Console.Write("Ingrese mes de nacimiento (Usar numero)\t");
                mes = int.Parse(Console.ReadLine());
                if (mes==0|mes>12){
                    Console.WriteLine("Ingrese mes valido");
                }
                else{
                    switch (mes){
                        case 1:
                            Console.Write("Ingrese dia \t");
                            dia = Convert.ToByte(Console.ReadLine());
                            if (dia == 0 | dia > 31){
                                Console.WriteLine("Ingrese dia valido \t");
                            }
                            else{
                                Edad[0] = 18;
                            }
                           break;

                        case 2:
                            
                           break;

                        case 3:
                            Console.Write("Ingrese dia \t");
                            dia = Convert.ToByte(Console.ReadLine());
                            if (dia == 0 | dia > 31){
                                Console.WriteLine("Ingrese dia valido \t");
                            }
                            else{
                                Edad[0] = 18;
                            }
                           break;

                        case 4:
                           Console.Write("Ingrese dia \t");
                           dia = Convert.ToByte(Console.ReadLine());
                           if (dia == 0 | dia > 30){
                               Console.WriteLine("Ingrese dia valido \t");
                           }
                           else{
                               Edad[0] = 18;
                           }
                           break;

                        case 5:
                            Console.Write("Ingrese dia \t");
                            dia = Convert.ToByte(Console.ReadLine());
                            if (dia == 0 | dia > 31){
                                Console.WriteLine("Ingrese dia valido \t");
                            }
                            else{
                                Edad[0] = 18;
                            }
                           break;

                        case 6:
                           Console.Write("Ingrese dia \t");
                           dia = Convert.ToByte(Console.ReadLine());
                           if (dia == 0 | dia > 30){
                               Console.WriteLine("Ingrese dia valido \t");
                           }
                           else{
                               Edad[0] = 18;
                           }
                           break;

                        case 7:
                            Console.Write("Ingrese dia \t");
                            dia = Convert.ToByte(Console.ReadLine());
                            if (dia == 0 | dia > 31){
                                Console.WriteLine("Ingrese dia valido \t");
                            }
                            else{
                                Edad[0] = 18;
                            }
                           break;

                        case 8:
                           Console.Write("Ingrese dia \t");
                           dia = Convert.ToByte(Console.ReadLine());
                           if (dia == 0 | dia > 31){
                               Console.WriteLine("Ingrese dia valido \t");
                           }
                           else{
                               Edad[0] = 18;
                           }
                           break;

                        case 9:
                           Console.Write("Ingrese dia \t");
                           dia = Convert.ToByte(Console.ReadLine());
                           if (dia == 0 | dia > 30){
                               Console.WriteLine("Ingrese dia valido \t");
                           }
                           else{
                               Edad[0] = 18;
                           }
                           break;

                        case 10:
                           Console.Write("Ingrese dia \t");
                           dia = Convert.ToByte(Console.ReadLine());
                           if (dia == 0 | dia > 31){
                               Console.WriteLine("Ingrese dia valido \t");
                           }
                           else{
                               Edad[0] = 18;
                           }
                           break;

                        case 11:
                           Console.Write("Ingrese dia \t");
                           dia = Convert.ToByte(Console.ReadLine());
                            if(año>=18){
                                Edad[0]=18;
                            }
                           if (dia==0|dia>30){
                               Console.WriteLine("Ingrese dia valido \t");
                           }
                           else{
                               if(dia==21){
                                   Edad[0] = 17;    
                               }
                           }
                           break;

                        case 12:
                           Edad[0] = 17;
                           break;


                    
                    }

                    Console.Clear();
                    if (Edad[0] >= 18){
                        Console.WriteLine("Usted es mayor de edad");
                    }
                    else{
                        Console.WriteLine("Usted es menor de edad");
                    }
                    
                }
            }

        }
    }
}
