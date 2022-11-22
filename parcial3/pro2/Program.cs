using System;

namespace IntercambiaElementos {
    class Program {
        private const int TAMANIO = 7;
        static void Main(string[] args){
            int[] arreglo = new int[TAMANIO];

            llenaArreglo(arreglo);
            intercambiaElementos(arreglo);
            imprimeArreglo(arreglo);
        }

        static void llenaArreglo(int[] arreglo){
            for(int i=0; i<TAMANIO;i++){
                Console.Write($"Valor de arreglo[{i}]: ");
                arreglo[i] = int.Parse(Console.ReadLine());
            }
        }

        static void intercambiaElementos(int[] arreglo){
            int mitad = (TAMANIO/2);
            int aux;
            for(int i=0;i<mitad;i++){
                aux=arreglo[i];
                arreglo[i] = arreglo[TAMANIO-i-1];
                arreglo[TAMANIO-i-1]=aux;
            }
        }

        static void imprimeArreglo(int[] arreglo){
            for(int i=0;i<TAMANIO;i++){
                Console.Write($"{arreglo[i]}\t");
            }
            Console.WriteLine();
        }
    }
}
