using System;

namespace Mayor{
    class Program {
        static void Main(string[] args){
            int n, mayor,indice=0;
            Console.Write("Escribe el número de elementos del arreglo: ");
            n=int.Parse(Console.ReadLine());
            int[] arreglo=new int[n];
            //Leemos los datos que irán en el arreglo
            for(int i=0;i<n;i++){
                Console.Write($"Escribe el valor de arreglo[{i}]: ");
                arreglo[i]=int.Parse(Console.ReadLine());
            }
            mayor=arreglo[0];
            for(int i=1;i<arreglo.Length;i++){
                if(mayor<arreglo[i]){
                    mayor=arreglo[i];
                    indice=i;
                }
            }

            Console.WriteLine($"La posición del elemento mayor es: {indice}");
        }
    }
}