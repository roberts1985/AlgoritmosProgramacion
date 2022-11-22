using System;

namespace pasoValores {
    class Program {
        static void Main(string[] args){
            int[] arreglo = {0,1,2,3,4};
            Console.WriteLine("Los valores del arreglo original son: ");
            imprimeArreglo(arreglo);
            Console.WriteLine("Los valores modificados del arreglo son: ");
            modificaArreglo(arreglo);
            imprimeArreglo(arreglo);

            Console.WriteLine("Paso de elemento del arreglo por valor...");
            Console.WriteLine($"El valor de arreglo[3] es: {arreglo[3]}");
            modificaElemento(arreglo[3]);
            Console.WriteLine($"El valor final de arreglo[3] es: {arreglo[3]}");

        }

        static void modificaArreglo(int[] arreglo){
            for(int i=0;i<arreglo.Length;i++){
                arreglo[i]=arreglo[i]*2;
                //arreglo[i] *= 2;
            }
        }

        static void modificaElemento(int elemento){
            elemento = elemento * 2;
            Console.WriteLine($"El valor modificado del elemento es: {elemento}");
        }

        static void imprimeArreglo(int[] arreglo){
            for(int i=0;i<arreglo.Length;i++){
                Console.Write($"{arreglo[i]}\t");
            }
            Console.WriteLine();
        }
    }
}
