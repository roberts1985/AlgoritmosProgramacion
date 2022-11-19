//Histograma
using System;

namespace Histograma{
    class Program{
        static void Main(string[] args){
            int[] arreglo = {6,8,10,5};

            Console.WriteLine("Elemento\tValor\tHistograma");
            for(int i=0;i<arreglo.Length;i++){
                Console.Write($"{i+1}\t\t{arreglo[i]}\t");
                for(int j=1;j<=arreglo[i];j++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
