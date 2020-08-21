using System;

namespace Observa
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = (150 - 20) / 2 + 5;
            //Expresion de calcular la superficie de un circulo
            double superficie = Math.PI * r * r;
            //Expresion de calcular el perimetros de un circulo
            double perimetro = 2 * Math.PI * r;
            Console.WriteLine(r);
            Console.WriteLine(superficie);
            Console.WriteLine(perimetro);
            Console.WriteLine();
            //Primer ejemplo
            double d = 1 / 2;
            Console.WriteLine(d);//0, no 0.5
            Console.WriteLine();
            //Segundo ejemplo
            double half = (double)1 / 2;
            Console.WriteLine(half);//0.5
            Console.WriteLine();
            //
            string name = "John";
            int age = 18;
            string town = "Seattle";
            Console.Write("{0} is {1} years old, from {2}!\n", name, age, town);
            Console.WriteLine();
            //
            int age2 = 26;
            string text = "He is " + age2 + " years old";
            Console.WriteLine(text);
            Console.WriteLine();
            //
            int a = 5;
            int b = ++a;
            Console.WriteLine(a);//6
            Console.WriteLine(b);//6
            Console.ReadKey();
        }
    }
}
