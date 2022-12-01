using System;

namespace sumaElementos{
    class Program{
        const int FILAS = 4;
        static void Main(string[] args){
            int[,] matriz = new int[FILAS,3];
            llenaMatriz(matriz);
            imprimeMatriz(matriz);
        }

        static void imprimeMatriz(int[,] matriz){
            for(int i=0;i<FILAS;i++){
                for(int j=0;j<3;j++){
                    Console.Write($"{matriz[i,j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void llenaMatriz(int[,] matriz){
            for(int i=0;i<FILAS;i++){
                Console.Write($"Escribe el elemento[{i},0]: ");
                matriz[i,0]=int.Parse(Console.ReadLine());
                Console.Write($"Escribe el elemento[{i},1]: ");
                matriz[i,1]=int.Parse(Console.ReadLine());
                matriz[i,2] = matriz[i,0]+matriz[i,1];
            }
        }
    }
}
