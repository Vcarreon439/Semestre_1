using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidencia_Practica_1_U3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Evidencia Practica 1 U3";
            string continuar = null;
            string Problema;
                        
            do {
            Console.Clear();
                Console.WriteLine("Elige una opcion: \n" +
                "\n 1. Precio de un terreno" +
                "\n 3. Almacen - Descuento" +
                "\n 4. Salario semanal" +
                "\n 5. Compra de camisas" +
                "\n 7. Tienda Promocion Bolitas");
                //Determinar problema a evaluar.
                Console.WriteLine("\n"+"Que programa desea evaluar?");
                Problema = Console.ReadLine();

                switch (Problema){
                   
                    //Problema 1.
                    case "1":
                        Console.Clear();
                        Console.Title = "Precio de un terreno";
                        Console.WriteLine("Eligio el problema 1");
                        Console.WriteLine("\n"+"Una persona desea calcular el precio de un terreno del cual se tienen los siguientes datos:" +
                        "largo, ancho y precio"+"\n"+ "por metro cuadrado. Si el terreno tiene más de 400 metros cuadrados se " +
                        "hace un descuento del 10 %.");
                        Console.ReadKey();
                        Console.Clear();
                        string repet;

                        //Aqui empieza el algoritmo para el problema.
                        //Ciclo por si desea evaluar mas terrenos.
                        do {
                            Console.Clear();
                            double length, width, area, cost;
                            Console.WriteLine("Cual es el largo del terreno?");
                            length = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Cual es el ancho del terreno?");
                            width = Convert.ToDouble(Console.ReadLine());
                            area = length * width;
                            Console.WriteLine("Cual es el costo del metro cuadrado?");
                            cost = Convert.ToDouble(Console.ReadLine());

                            //Evaluar si se hace el descuento.
                            if (area > 400) {
                                Console.WriteLine("El costo del terreno sin descuento es de: " + "\t" + "$" + (cost * area));
                                cost = (cost * area) * .90;
                                Console.WriteLine("El costo del terreno con descuento es de " + "\t" + "$" + cost);
                            }
                            else {
                                cost = cost * area;
                                Console.WriteLine("El costo del terreno es de " + "$" + cost);
                            }

                            Console.Write("Desea repetir el problema (S/N)" + "\t");
                            repet = Console.ReadLine();
                        }
                        while (repet=="S"| repet=="s");
                        repet = null;
                        break;
                        
                    //Problema 3.
                    case "3":
                        Console.Clear();
                        Console.Title= "Almacen - Descuento";
                        Console.WriteLine("Eligio el problema 3"+"\n");
                        Console.WriteLine("En un almacén se hace un 20% de descuento a los clientes cuya compra supere los $1000 " + "\n" +
                        "¿Cuál será la cantidad que pagara una persona por su compra ? ");
                        Console.ReadKey();
                        Console.Clear();
                        //Aqui empieza el algoritmo.
                        //Ciclo por si desea evaluar mas articulos.
                        do{
                            string art;
                            Console.Write("Ingrese nombre del articulo"+"\t");
                            art = Console.ReadLine();
                            double cant, cost;
                            Console.Write("Ingrese el costo del producto" +"\t"+ "$");
                            cost = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese la cantidad de "+ art + "\t");
                            cant = Convert.ToDouble(Console.ReadLine());
                            cost = cost * cant;
                            Console.Clear();
                            //Evaluar si hace descuento.
                            if (cost>1000) {
                                Console.WriteLine("Su compra supera los $1000, por lo cual se le hara un descuento del 20%");
                                Console.WriteLine("El costo de sus "+ art + " sin descuento era de: "+"$" + cost);
                                cost = cost * .80;
                                Console.WriteLine("El total con descuento sera de: " + "$" + cost);
                            }
                            else{
                                Console.WriteLine("El total de sus "+ art + " es de " +"$"+ cost);
                            }
                            //Evaluar si desea repetir el algoritmo del problema 3.
                            Console.Write("Desea repetir el problema (S/N)" + "\t");
                            repet = Console.ReadLine();
                            Console.Clear();
                        }
                        while (repet == "S" | repet == "s");
                        repet = null;
                        break;

                    //Problema 4.
                    case "4":
                        Console.Clear();
                        Console.Title = "Salario Semanal";
                        Console.WriteLine("Eligio el problema 4");
                        Console.WriteLine("\n"+"Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera:" +"\n" +
                        "Si trabaja 40 horas o menos se le paga $16 por hora" +"\n"+
                        "Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas" +
                        " y $20 por cada hora extra.");
                        Console.ReadKey();
                        Console.Clear();
                        //Aqui empieza el algoritmo.
                        //Ciclo por si desea evaluar mas horas.
                        do {
                            double horst, salar;
                            Console.Write("Cuantas horas ha trabajado?"+"\t");
                            horst = Convert.ToDouble(Console.ReadLine());
                            //Evalua si trabaja 40 horas o menos
                            if (horst<40|horst==40) {
                                salar = horst * 16;
                                Console.WriteLine("Su salario es de: " +"\t" + "$" + salar);
                            }
                            else {
                                //Saca el salario con la condicion dada por el problema.
                                if(horst>40){
                                    salar = 40 * 16;
                                    horst = horst-40;
                                    horst = horst * 20;
                                    salar = salar + horst;
                                    Console.WriteLine("Su salario es de: " + "\t" + "$" +salar);

                                }
                            }
                                                        
                            //Evaluar si desea repetir el algoritmo del problema 4.
                            Console.Write("Desea repetir el problema (S/N)" + "\t");
                            repet = Console.ReadLine();
                            Console.Clear();
                        }
                        while (repet == "S" | repet == "s");
                        repet = null;
                        break;

                    //Problema 5.
                    case "5":
                        Console.Clear();
                        Console.Title = "Compra de camisas";
                        Console.WriteLine("Eligio el problema 5"+"\n");
                        Console.WriteLine("Hacer un algoritmo que calcule el total a pagar por la compra de camisas." +"\n"+"Si se compran tres"+
                        "camisas o más se aplica un descuento del 20 % sobre el"+"\n"+ "total de la compra y si son menos de" +
                        "tres camisas un descuento del 10 % ");
                        Console.ReadKey();
                        Console.Clear();
                        //Aqui empieza el algoritmo.
                        //Ciclo por si desea evaluar mas camisas.
                        do {
                            double cam, cost;
                            Console.WriteLine("Cuantas camisas compro?");
                            cam = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Cual es el costo de la camiseta?");
                            cost = Convert.ToDouble(Console.ReadLine());
                            cost = cam * cost;
                            Console.Clear();
                            //Evalua si se compraron 3 o mas camisas.
                            if (cam == 3 | cam > 3){
                                Console.WriteLine("Como compro 3 o mas camisetas, se le hara un descuento del 20%");
                                Console.WriteLine("El costo sin descuento hubiera sido de: " + "$" + cost);
                                cost = cost * .80;
                                Console.WriteLine("El total es de: " + "$" + cost);
                            }
                            else {
                                cost = cost * .90;
                                Console.WriteLine("El costo de las camisetas es de: " + "$" + cost);
                            }
                            //Evaluar si desea repetir el algoritmo del problema 5.
                            Console.Write("\n"+"Desea repetir el problema (S/N)" + "\t");
                            repet = Console.ReadLine();
                            Console.Clear();
                        }
                        while (repet == "S" | repet == "s");
                        repet = null;
                        break;

                    //Problema 7.
                    case "7":
                        Console.Clear();
                        Console.Title = "Tienda promocion bolitas";
                        Console.WriteLine("Eligio el problema 7"+"\n");
                        Console.WriteLine("En una tienda de descuento se efectúa una promoción en la cual se hace un descuento sobre "+
                        "el valor de la compra total" +"\n"+ "según el color de la bolita que el cliente saque al pagar en caja. Si la "+
                        "bolita es de color blanco no se le hará"+"\n" +"descuento alguno, si es verde se le hará un 10 % de"+
                        "descuento, si es amarilla un 25 %, si es azul un 50 %"+"\n"+"y si es roja un 100 %. Determinar la cantidad "+
                        "final que el cliente deberá pagar por su compra."+"\n"+"Se sabe que solo hay bolitas de los colores"+
                        " mencionados."+"\n");
                        Console.ReadKey();
                        Console.Clear();
                        //Aqui empieza el algoritmo.
                        //Ciclo por si desea evaluar mas casos.
                        do {
                            string bolita;
                            double subt, total;
                            Console.Write("Ingrese el subtotal"+"\t"+"$");
                            subt = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("\n 1.Blanca" +
                                "\n 2.Verde" +
                                "\n 3.Amarilla" +
                                "\n 4.Azul" +
                                "\n 5.Roja");

                            Console.WriteLine("\nDe que color es la bolita?");
                            bolita = Console.ReadLine();
                            Console.Clear();
                            //Por si escriben blanca de deiferentes maneras
                            if (bolita == "blanca" | bolita == "blanco" | bolita == "Blanca" | bolita == "Blanco"|bolita=="BLANCA"|bolita=="BLANCO") {
                                bolita = "blanca";
                            }
                            //Por si escriben verde de deiferentes maneras
                            if (bolita == "Verde" | bolita == "verde" | bolita == "VERDE"){
                                bolita = "verde";
                            }
                            //Por si escriben amarilla de deiferentes maneras
                            if (bolita == "Amarilla" | bolita == "amarilla" | bolita == "AMARILLA"){
                                bolita = "amarilla";
                            }
                            //Por si escriben amarilla de deiferentes maneras
                            if (bolita == "Azul" | bolita == "azul" | bolita == "AZUL"){
                                bolita = "azul";
                            }
                            //Por si escriben amarilla de deiferentes maneras
                            if (bolita == "Roja" | bolita == "roja" | bolita == "ROJA"){
                                bolita = "roja";
                            }
                            //Evaluar el descuento segun el color de la bolita
                            switch (bolita){
                                case "blanca":
                                    Console.WriteLine("Suerte para la proxima");
                                    total = subt;
                                    Console.WriteLine("El total a pagar es de: " + "$" + total);
                                    break;
                                case "verde":
                                    Console.WriteLine("Felicidades ha recibido un descuento del 10%");
                                    total = subt * .90;
                                    Console.WriteLine("El total a pagar es de: " + "$" + total);
                                    break;
                                case "amarilla":
                                    Console.WriteLine("Felicidades ha recibido un descuento del 25%");
                                    total = subt * .85;
                                    Console.WriteLine("El total a pagar es de: " + "$" + total);
                                    break;
                                case "azul":
                                    Console.WriteLine("Felicidades ha recibido un descuento del 50%");
                                    total = subt * .50;
                                    Console.WriteLine("El total a pagar es de: " + "$" + total);
                                    break;
                                case "roja":
                                    Console.WriteLine("Felicidades ha recibido un descuento del 100%");
                                    break;
                                default:
                                    Console.WriteLine("Escriba una opcion valida");
                                    break;
                            }
                                                       
                            //Evaluar si desea repetir el algoritmo del problema 7
                            Console.Write("\n" + "Desea repetir el problema (S/N)" + "\t");
                            repet = Console.ReadLine();
                            Console.Clear();
                        }
                        while (repet == "S" | repet == "s");
                        repet = null;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Seleccione una opcion valida"+"\n");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Desea evaluar otro ejercicio? (S/N)" + "\t");
                continuar = Console.ReadLine();
            }
            while (continuar == "S" | continuar == "s");
        }
    }
}