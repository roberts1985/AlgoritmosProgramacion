using System;

namespace Fibo {
    class Program {
        static void Main(string[] args){
            int n;
            Console.Write("Escribe el número de elementos de la serie: ");
            n = int.Parse(Console.ReadLine());
            int[] fibo = new int[n];
            fibo[0] = 1;
            fibo[1] = 1;
            for(int indice = 2;indice < n;indice++){
                fibo[indice] = fibo[indice-1]+fibo[indice-2];
            }
            for(int indice = 0;indice<n;indice++){
                Console.Write($"{fibo[indice]}\t");
            }
        }
    }
}
