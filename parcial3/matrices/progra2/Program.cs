using System;

namespace sumaElementosMatriz{
    class Program {
        static void Main(string[] args){
            int m,n,resultado;
            Console.Write("Escribe el valor de m: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Escribe el valor de n: ");
            n = int.Parse(Console.ReadLine());
            int[ , ] matriz = new int[m,n];
            llenaMatriz(matriz,m,n);
            resultado=sumaElementos(matriz,m,n);
            Console.WriteLine($"La suma es: {resultado}");
        }

        static void llenaMatriz(int[,] matriz,int m, int n){
            for(int i=0;i<m;i++){
                for(int j=0;j<n;j++){
                    Console.Write($"Valor de matriz[{i},{j}]: ");
                    matriz[i,j]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }

        static int sumaElementos(int[,] matriz, int m, int n){
            int suma=0;

            for(int i=0;i<m;i++){
                for(int j=0;j<n;j++){
                    suma = suma + matriz[i,j];
                }
            }

            return suma;
        }
    }
}
