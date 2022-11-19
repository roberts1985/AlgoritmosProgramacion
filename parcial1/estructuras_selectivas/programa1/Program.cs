//Determinar si una persona es mayor de edad
using System;

namespace Edad1{
    class Program{
        static void Main(string[] args){
            int edad;

            Console.Write("Escribe tu edad: ");
            edad=int.Parse(Console.ReadLine());

            if(edad>=18){
                Console.WriteLine("Eres mayor de edad...");
            }
        }
    }
}
