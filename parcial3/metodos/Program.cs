using System;

namespace Calculadora {
    class Program{
        static void Main(string[] args){
            int opcion;

            do {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                opcion = int.Parse(Console.ReadLine());
            }while(opcion<1 || opcion > 4);

            switch(opcion){
                case 1:
                    Sumar();
                    break;
                case 2:
                    Restar(4,1);
                    break;
                case 3:
                    Console.WriteLine($"El producto es: {Multiplicar()}");
                    break;
                case 4:
                    Console.WriteLine($"La división es: {Dividir(7,2)}");
                    break;
                default:
                    Console.WriteLine("Opción incorrecta...");
                    break;
            }
        }

        static void Sumar(){
            int a, b,resultado;

            Console.Write("Escribe un número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Escribe otro número: ");
            b = int.Parse(Console.ReadLine());
            resultado = a + b;
            Console.WriteLine($"La suma es: {resultado}");
        }

        static void Restar(int a, int b){
            int resultado;

            resultado = a - b;
            Console.WriteLine($"La resta es: {resultado}");
        }

        static int Multiplicar(){
            int a, b;

            Console.Write("Escribe un número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Escribe otro número: ");
            b = int.Parse(Console.ReadLine());

            return a*b;
        }

        static decimal Dividir(decimal a, decimal b){
            decimal resultado;

            resultado = a / b;

            return resultado;
        }
    }
}
