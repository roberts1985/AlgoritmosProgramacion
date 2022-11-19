//Intercambia variables
using System;

namespace intercambia{
    class Program{
        static void Main(string[] args){
            int a, b, aux;
            Console.Write("Ingresa el valor de a: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de b: ");
            b=int.Parse(Console.ReadLine());
            aux=a;
            a=b;
            b=aux;
            Console.WriteLine($"El nuevo valor de a es: {a}");
            Console.WriteLine($"El nuevo valor de b es: {b}");
        }
    }
}