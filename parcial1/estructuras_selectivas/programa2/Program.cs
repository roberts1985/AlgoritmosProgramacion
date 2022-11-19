//determina si una persona es mayor o menor de edad
using System;

namespace Edad2{
    class Program{
        static void Main(string[] args){
            int edad;

            Console.Write("Escribe tu edad: ");
            edad=int.Parse(Console.ReadLine());

            if(edad>=18){
                Console.WriteLine("Eres mayor de edad...");
            }else{
                Console.WriteLine("Eres menor de edad...");
            }
        }
    }
}
