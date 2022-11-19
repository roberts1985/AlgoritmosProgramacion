using System;

namespace pasoArreglo{
    class Program{
        static void Main(string[] args){
            int[] arreglo = {0,1,2,3,4,5,6,7,8,9};

            imprimirArreglo(arreglo);
        }

        static void imprimirArreglo(int[] arreglo){
            for(int i=0;i<arreglo.Length;i++){
                Console.WriteLine(arreglo[i]);
            }
        }
    }
}
