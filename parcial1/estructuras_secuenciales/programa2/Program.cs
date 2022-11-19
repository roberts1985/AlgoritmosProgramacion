//Suma de dos números
using System;

namespace Suma{
    class Program{
        static void Main(string[] args){
            int num1, num2, suma;

            Console.Write("Ingresa un número: ");
            num1=int.Parse(Console.ReadLine());
            Console.Write("Ingresa un número: ");
            num2=int.Parse(Console.ReadLine());
            suma=num1+num2;
            Console.WriteLine($"La suma es: {suma}");
        }
    }
}
