using System;

namespace promedioArreglo{
    class Program{
        static void Main(string[] args){
            int n;

            Console.Write("Escribe el valor de n: ");
            n = int.Parse(Console.ReadLine());
            double[] arreglo = new double[n];

            llenaArreglo(arreglo,n);
            Console.WriteLine($"El promedio es: {calcularPromedio(arreglo)}");
            imprimirArreglo(arreglo);
        }

        static void llenaArreglo(double[] arreglo,int n){
            for(int i=0;i<n;i++) {
                Console.Write($"Ingresa el valor de arreglo[{i}]: ");
                arreglo[i] = double.Parse(Console.ReadLine());
            }
        }

        static double calcularPromedio(double[] arreglo) {
            double promedio, suma=0;

            for(int i=0;i<arreglo.Length;i++){
                suma = suma + arreglo[i];
            }
            promedio=suma/arreglo.Length;

            return promedio;
        }

        static void imprimirArreglo(double[] arreglo) {
            for(int i=0;i<arreglo.Length;i++){
                Console.WriteLine($"El elemento {i} del arreglo es: {arreglo[i]}");
            }
        }
    }
}