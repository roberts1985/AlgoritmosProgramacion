using System;

namespace SumaMatrices {
    class Program{
        const int FILA = 2;
        const int COLUMNA = 2;
        static void Main(string[] args){
            int[,] matrizA = new int[FILA,COLUMNA];
            int[,] matrizB = new int[FILA,COLUMNA];
            int[,] matrizC = new int[FILA,COLUMNA];

            Console.WriteLine("Matriz A");
            llenaMatriz(matrizA);
            Console.WriteLine("Matriz B");
            llenaMatriz(matrizB);
            SumaMatrices(matrizA,matrizB,matrizC);
            Console.WriteLine("La suma es...");
            imprimirMatriz(matrizC);
        }

        static void imprimirMatriz(int[ , ] matriz){
            for(int i=0;i<FILA;i++){
                for(int j=0;j<COLUMNA;j++){
                    Console.Write($"{matriz[i,j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void SumaMatrices(int[,] A, int[,] B, int[,] C){
            for(int i=0;i<FILA;i++){
                for(int j=0;j<COLUMNA;j++){
                    C[i,j] = A[i,j] + B[i,j];
                }
            }
        }

        static void llenaMatriz(int[ , ] matriz){
            for(int i=0;i<FILA;i++){
                for(int j=0;j<COLUMNA;j++){
                    Console.Write($"Ingresa matriz[{i},{j}]: ");
                    matriz[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
