//Triángulo de números...
using System;

namespace Triangulo {
    class Program{
        static void Main(string[] args){
            int n;

            Console.Write("Escribe el valor de n: ");
            n=int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++){
                for(int j=1;j<=i;j++){
                    Console.Write($"{j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}